﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Notepad_.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.8.1.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("White")]
        public global::System.Drawing.Color backgroundColor {
            get {
                return ((global::System.Drawing.Color)(this["backgroundColor"]));
            }
            set {
                this["backgroundColor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Black")]
        public global::System.Drawing.Color fontColor {
            get {
                return ((global::System.Drawing.Color)(this["fontColor"]));
            }
            set {
                this["fontColor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public string[] openedFiles {
            get {
                return ((string[])(this["openedFiles"]));
            }
            set {
                this["openedFiles"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("ForestGreen")]
        public global::System.Drawing.Color commentsColor {
            get {
                return ((global::System.Drawing.Color)(this["commentsColor"]));
            }
            set {
                this["commentsColor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Green")]
        public global::System.Drawing.Color commentDocColor {
            get {
                return ((global::System.Drawing.Color)(this["commentDocColor"]));
            }
            set {
                this["commentDocColor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Chocolate")]
        public global::System.Drawing.Color stringColor {
            get {
                return ((global::System.Drawing.Color)(this["stringColor"]));
            }
            set {
                this["stringColor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("RoyalBlue")]
        public global::System.Drawing.Color keyWordsColor {
            get {
                return ((global::System.Drawing.Color)(this["keyWordsColor"]));
            }
            set {
                this["keyWordsColor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Firebrick")]
        public global::System.Drawing.Color operatorsColor {
            get {
                return ((global::System.Drawing.Color)(this["operatorsColor"]));
            }
            set {
                this["operatorsColor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("60000")]
        public int timeInterval {
            get {
                return ((int)(this["timeInterval"]));
            }
            set {
                this["timeInterval"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool isAutosaveEnabled {
            get {
                return ((bool)(this["isAutosaveEnabled"]));
            }
            set {
                this["isAutosaveEnabled"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool isLoggingEnabled {
            get {
                return ((bool)(this["isLoggingEnabled"]));
            }
            set {
                this["isLoggingEnabled"] = value;
            }
        }
    }
}
