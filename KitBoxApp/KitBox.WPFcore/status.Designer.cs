﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KitBox.WPFcore {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class status {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal status() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("KitBox.WPFcore.status", typeof(status).Assembly);
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
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Canceled.
        /// </summary>
        public static string PaymentStatus_Canceled {
            get {
                return ResourceManager.GetString("PaymentStatus_Canceled", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Payed.
        /// </summary>
        public static string PaymentStatus_Payed {
            get {
                return ResourceManager.GetString("PaymentStatus_Payed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Prepaid.
        /// </summary>
        public static string PaymentStatus_Prepaid {
            get {
                return ResourceManager.GetString("PaymentStatus_Prepaid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Pending.
        /// </summary>
        public static string PaymentStatus_Unpayed {
            get {
                return ResourceManager.GetString("PaymentStatus_Unpayed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Not Processed.
        /// </summary>
        public static string PreparationStatus_NotProcessed {
            get {
                return ResourceManager.GetString("PreparationStatus_NotProcessed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Ready.
        /// </summary>
        public static string PreparationStatus_Ready {
            get {
                return ResourceManager.GetString("PreparationStatus_Ready", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Shipped Out.
        /// </summary>
        public static string PreparationStatus_ShippedOut {
            get {
                return ResourceManager.GetString("PreparationStatus_ShippedOut", resourceCulture);
            }
        }
    }
}
