﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace crtcpl.StringRes {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class StringRes {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal StringRes() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("crtcpl.StringRes.StringRes", typeof(StringRes).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error occurred while instructing the IVAD to make all changes permanent. {0}.
        /// </summary>
        internal static string CantApplyChanges {
            get {
                return ResourceManager.GetString("CantApplyChanges", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error occurred while instructing the IVAD to make the requested change. {0}.
        /// </summary>
        internal static string CantPerformChange {
            get {
                return ResourceManager.GetString("CantPerformChange", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error occurred while instructing the IVAD controller to restore default values. {0}.
        /// </summary>
        internal static string CantResetDefaults {
            get {
                return ResourceManager.GetString("CantResetDefaults", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error occurred while instructing the IVAD controller to undo unsaved changes. {0}.
        /// </summary>
        internal static string CantUndoChanges {
            get {
                return ResourceManager.GetString("CantUndoChanges", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error occurred while retrieving the current configuration from the IVAD controller. {0}.
        /// </summary>
        internal static string CantUpdatePages {
            get {
                return ResourceManager.GetString("CantUpdatePages", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The selected control port is invalid..
        /// </summary>
        internal static string ComErrorBadPort {
            get {
                return ResourceManager.GetString("ComErrorBadPort", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This program is not compatible with the attached IVAD controller..
        /// </summary>
        internal static string ComErrorBadVersion {
            get {
                return ResourceManager.GetString("ComErrorBadVersion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error occurred while connecting to the IVAD control port. {0}.
        /// </summary>
        internal static string ComErrorOther {
            get {
                return ResourceManager.GetString("ComErrorOther", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to IVAD Control Port.
        /// </summary>
        internal static string ComErrorTitle {
            get {
                return ResourceManager.GetString("ComErrorTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An invalid response was received..
        /// </summary>
        internal static string UCComBadResponse {
            get {
                return ResourceManager.GetString("UCComBadResponse", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The port is in an invalid state..
        /// </summary>
        internal static string UCComIOError {
            get {
                return ResourceManager.GetString("UCComIOError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No response was received..
        /// </summary>
        internal static string UCComNoResponse {
            get {
                return ResourceManager.GetString("UCComNoResponse", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Access is denied to the port. Another program probably already has the specified COM port open..
        /// </summary>
        internal static string UCComUnauthorizedAccess {
            get {
                return ResourceManager.GetString("UCComUnauthorizedAccess", resourceCulture);
            }
        }
    }
}
