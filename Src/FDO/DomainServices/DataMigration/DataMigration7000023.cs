// ---------------------------------------------------------------------------------------------
#region // Copyright (c) 2010, SIL International. All Rights Reserved.
// <copyright from='2010' to='2010' company='SIL International'>
//		Copyright (c) 2010, SIL International. All Rights Reserved.   
//    
//		Distributable under the terms of either the Common Public License or the
//		GNU Lesser General Public License, as specified in the LICENSING.txt file.
// </copyright> 
#endregion
// 
// File: DataMigration7000023.cs
// Responsibility: Randy Regnier
// 
// <remarks>
// </remarks>
// ---------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Xml.XPath;

namespace SIL.FieldWorks.FDO.DomainServices.DataMigration
{
	/// ----------------------------------------------------------------------------------------
	/// <summary>
	/// Migrate data from 7000022 to 7000023. 
	/// </summary>
	/// ----------------------------------------------------------------------------------------
	internal class DataMigration7000023 : IDataMigration
	{
		#region Implementation of IDataMigration

		/// ------------------------------------------------------------------------------------
		/// <summary>
		/// Change all guids to lowercase to help the Chorus diff/merge code.
		/// </summary>
		/// ------------------------------------------------------------------------------------
		public void PerformMigration(IDomainObjectDTORepository domainObjectDtoRepository)
		{
			DataMigrationServices.CheckVersionNumber(domainObjectDtoRepository, 7000022);

			foreach (var dto in domainObjectDtoRepository.AllInstancesWithValidClasses())
			{
				var rtElement = XElement.Parse(dto.Xml);
				if (ShiftCase(rtElement))
					DataMigrationServices.UpdateDTO(domainObjectDtoRepository, dto, rtElement.ToString());
			}

			DataMigrationServices.IncrementVersionNumber(domainObjectDtoRepository);
		}

		private static bool ShiftCase(XElement rtElement)
		{
			var didShiftCase = false;
			// General places to find guids:
			// Main rt element's guid attr
			// Main rt element's optional ownerguid attr
			ShiftCase(rtElement, "guid", ref didShiftCase);
			if (rtElement.Attribute("ownerguid") != null)
				ShiftCase(rtElement, "ownerguid", ref didShiftCase);

			// objsur's guid attr (objsur is optional, but if found, the guid attr is required).
			foreach (var osElement in rtElement.Descendants("objsur"))
				ShiftCase(osElement, "guid", ref didShiftCase);

			// Classes that use a Guid in a property.
			string propertyName;
			switch (rtElement.Attribute("class").Value)
			{
				default:
					propertyName = null;
					break;
				case "CmPossibilityList":
					propertyName = "ListVersion";
					break;
				case "CmFilter": // Fall through.
				case "UserView":
					propertyName = "App";
					break;
				case "UserAppFeatAct":
					propertyName = "ApplicationId";
					break;
				case "CmResource":
					propertyName = "Version";
					break;
				case "ScrCheckRun":
					propertyName = "CheckId";
					break;
			}
			if (propertyName != null)
				ShiftCase(rtElement.Element(propertyName), "val", ref didShiftCase);

			return didShiftCase;
		}

		private static void ShiftCase(XElement element, string attrName, ref bool didShiftCase)
		{
			if (element == null)
				return; // It may be null, if the project was just created and is being migrated.

			var attr = element.Attribute(attrName);
			if (!HasUpperCase(attr.Value))
				return;

			didShiftCase = true;
			attr.Value = attr.Value.ToLowerInvariant();
		}

		private static bool HasUpperCase(IEnumerable<char> guid)
		{
			return guid.Any(character => char.IsUpper(character));
		}

		#endregion
	}
}
