﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SIL.CoreImpl.Properties {


    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "12.0.0.0")]
    public sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {

        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));

        /// <summary>
        ///
        /// </summary>
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }

        /// <summary>
        /// Setting controling the updating of the Global WS Store
        /// </summary>
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(SIL.Settings.CrossPlatformSettingsProvider))]
        [global::System.Configuration.SettingsDescriptionAttribute("Setting controling the updating of the Global WS Store")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool UpdateGlobalWSStore {
            get {
                return ((bool)(this["UpdateGlobalWSStore"]));
            }
            set {
                this["UpdateGlobalWSStore"] = value;
            }
        }

        /// <summary>
        /// Setting to store Reporting options
        /// </summary>
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(SIL.Settings.CrossPlatformSettingsProvider))]
        [global::System.Configuration.SettingsDescriptionAttribute("Setting to store Reporting options")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::SIL.Reporting.ReportingSettings Reporting {
            get {
                return ((global::SIL.Reporting.ReportingSettings)(this["Reporting"]));
            }
            set {
                this["Reporting"] = value;
            }
        }

        /// <summary>
        /// Setting controling if updates are checked automatically
        /// </summary>
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(SIL.Settings.CrossPlatformSettingsProvider))]
        [global::System.Configuration.SettingsDescriptionAttribute("Setting controling if updates are checked automatically")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool AutoCheckForUpdates {
            get {
                return ((bool)(this["AutoCheckForUpdates"]));
            }
            set {
                this["AutoCheckForUpdates"] = value;
            }
        }

        /// <summary>
        /// Setting controlling if Beta updates should be checked
        /// </summary>
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(SIL.Settings.CrossPlatformSettingsProvider))]
        [global::System.Configuration.SettingsDescriptionAttribute("Setting controlling if Beta updates should be checked")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool CheckForBetaUpdates {
            get {
                return ((bool)(this["CheckForBetaUpdates"]));
            }
            set {
                this["CheckForBetaUpdates"] = value;
            }
        }

        /// <summary>
        /// Setting to show if this is a BTE version (used for update checks)
        /// </summary>
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(SIL.Settings.CrossPlatformSettingsProvider))]
        [global::System.Configuration.SettingsDescriptionAttribute("Setting to show if this is a BTE version (used for update checks)")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool IsBTE {
            get {
                return ((bool)(this["IsBTE"]));
            }
            set {
                this["IsBTE"] = value;
            }
        }

        /// <summary>
        /// Setting indicating that the Settings need to be upgraded
        /// </summary>
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(SIL.Settings.CrossPlatformSettingsProvider))]
        [global::System.Configuration.SettingsDescriptionAttribute("Setting indicating that the Settings need to be upgraded")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool CallUpgrade {
            get {
                return ((bool)(this["CallUpgrade"]));
            }
            set {
                this["CallUpgrade"] = value;
            }
        }

        /// <summary>
        /// Setting to store current keyboard assignments for writing systems
        /// </summary>
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(SIL.Settings.CrossPlatformSettingsProvider))]
        [global::System.Configuration.SettingsDescriptionAttribute("Setting to store current keyboard assignments for writing systems")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string LocalKeyboards {
            get {
                return ((string)(this["LocalKeyboards"]));
            }
            set {
                this["LocalKeyboards"] = value;
            }
        }

        /// <summary>
        /// Stores last used user for webonary export
        /// </summary>
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(SIL.Settings.CrossPlatformSettingsProvider))]
        [global::System.Configuration.SettingsDescriptionAttribute("Stores last used user for webonary export")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string WebonaryUser {
            get {
                return ((string)(this["WebonaryUser"]));
            }
            set {
                this["WebonaryUser"] = value;
            }
        }

        /// <summary>
        /// stores last password for webonary export
        /// </summary>
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(SIL.Settings.CrossPlatformSettingsProvider))]
        [global::System.Configuration.SettingsDescriptionAttribute("stores last password for webonary export")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string WebonaryPass {
            get {
                return ((string)(this["WebonaryPass"]));
            }
            set {
                this["WebonaryPass"] = value;
            }
        }
    }
}
