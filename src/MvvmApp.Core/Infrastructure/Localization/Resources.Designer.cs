﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MvvmApp.Core.Infrastructure.Localization {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("MvvmApp.Core.Infrastructure.Localization.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to Form Page.
        /// </summary>
        internal static string FormPage_Description {
            get {
                return ResourceManager.GetString("FormPage_Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Go back to nav page.
        /// </summary>
        internal static string NoNavPage_BackButton {
            get {
                return ResourceManager.GetString("NoNavPage_BackButton", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This page has no navigation panel and is being rendered from MainPage..
        /// </summary>
        internal static string NoNavPage_BodyText {
            get {
                return ResourceManager.GetString("NoNavPage_BodyText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Settings Page.
        /// </summary>
        internal static string SettingsPage_Description {
            get {
                return ResourceManager.GetString("SettingsPage_Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This welcome page is rendered from the NavPage NavigationView which in turn is rendered in the MainPage..
        /// </summary>
        internal static string WelcomePage_Description {
            get {
                return ResourceManager.GetString("WelcomePage_Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Go to Form page.
        /// </summary>
        internal static string WelcomePage_NavigateFormPageButton {
            get {
                return ResourceManager.GetString("WelcomePage_NavigateFormPageButton", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Go to NoNav page.
        /// </summary>
        internal static string WelcomePage_NavigateNoNavButton {
            get {
                return ResourceManager.GetString("WelcomePage_NavigateNoNavButton", resourceCulture);
            }
        }
    }
}
