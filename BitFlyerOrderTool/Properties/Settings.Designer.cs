﻿//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン:4.0.30319.42000
//
//     このファイルへの変更は、以下の状況下で不正な動作の原因になったり、
//     コードが再生成されるときに損失したりします。
// </auto-generated>
//------------------------------------------------------------------------------

namespace BitFlyerOrderApp.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.6.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string API_KEY {
            get {
                return ((string)(this["API_KEY"]));
            }
            set {
                this["API_KEY"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string API_SECRET {
            get {
                return ((string)(this["API_SECRET"]));
            }
            set {
                this["API_SECRET"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("5")]
        public int DEFAULT_EXPIRE_TIME {
            get {
                return ((int)(this["DEFAULT_EXPIRE_TIME"]));
            }
            set {
                this["DEFAULT_EXPIRE_TIME"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1")]
        public decimal DEFAULT_ORDER_SIZE {
            get {
                return ((decimal)(this["DEFAULT_ORDER_SIZE"]));
            }
            set {
                this["DEFAULT_ORDER_SIZE"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("5000")]
        public decimal DEFAULT_STOP_LIMIT {
            get {
                return ((decimal)(this["DEFAULT_STOP_LIMIT"]));
            }
            set {
                this["DEFAULT_STOP_LIMIT"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool USE_STOP {
            get {
                return ((bool)(this["USE_STOP"]));
            }
            set {
                this["USE_STOP"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("GTC")]
        public string DEFAULT_TIME_IN_FORCE {
            get {
                return ((string)(this["DEFAULT_TIME_IN_FORCE"]));
            }
            set {
                this["DEFAULT_TIME_IN_FORCE"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public decimal DEFAULT_ORDER_RETRY {
            get {
                return ((decimal)(this["DEFAULT_ORDER_RETRY"]));
            }
            set {
                this["DEFAULT_ORDER_RETRY"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0.5")]
        public decimal DEFAULT_ORDER_SAFTY_LIMIT {
            get {
                return ((decimal)(this["DEFAULT_ORDER_SAFTY_LIMIT"]));
            }
            set {
                this["DEFAULT_ORDER_SAFTY_LIMIT"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("NONE")]
        public string DEFAULT_INPUT_PRICE_FIX {
            get {
                return ((string)(this["DEFAULT_INPUT_PRICE_FIX"]));
            }
            set {
                this["DEFAULT_INPUT_PRICE_FIX"] = value;
            }
        }
    }
}
