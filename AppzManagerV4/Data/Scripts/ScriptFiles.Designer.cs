﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AppzManagerV4.Data.Scripts {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class ScriptFiles {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ScriptFiles() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("AppzManagerV4.Data.Scripts.ScriptFiles", typeof(ScriptFiles).Assembly);
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
        ///   Looks up a localized string similar to CREATE TABLE &quot;Apps&quot; 
        ///(
        ///    &quot;Id&quot; INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL ,
        ///    &quot;Name&quot; NVARCHAR(100),
        ///    &quot;Path&quot; NVARCHAR(1000),
        ///    &quot;IconPath&quot; NVARCHAR(1000),
        ///    &quot;Comment&quot; NVARCHAR(2000),
        ///    &quot;Shortcut&quot; NVARCHAR(20),
        ///    &quot;GroupId&quot; INT,
        ///    &quot;Error&quot; BOOL DEFAULT (0) ,
        ///    &quot;ShowInContextMenu&quot; BOOL DEFAULT (0) ,
        ///    &quot;ImageIndex&quot; INT,
        ///    &quot;ColorCode&quot; NVARCHAR(20),
        ///    &quot;ExecuteIn&quot; NVARCHAR(100),
        ///    &quot;Version&quot; NVARCHAR(50),
        ///    &quot;Parameter&quot; NVARCHAR(100),
        ///    &quot;Autostart&quot; BOOL DEFAULT (0) 
        ///).
        /// </summary>
        internal static string CreateTable_App {
            get {
                return ResourceManager.GetString("CreateTable_App", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CREATE TABLE &quot;Files&quot; 
        ///(
        ///    &quot;Id&quot; INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL ,
        ///    &quot;Name&quot; NVARCHAR(100),
        ///    &quot;Path&quot; NVARCHAR(1000),
        ///    &quot;Comment&quot; NVARCHAR(2000),
        ///    &quot;Shortcut&quot; NVARCHAR(20),
        ///    &quot;GroupId&quot; INT,
        ///    &quot;Error&quot; BOOL DEFAULT (0),
        ///    &quot;ShowInContextMenu&quot; BOOL DEFAULT (0),
        ///    &quot;ImageIndex&quot; INT,
        ///    &quot;ColorCode&quot; NVARCHAR(20)
        ///).
        /// </summary>
        internal static string CreateTable_Files {
            get {
                return ResourceManager.GetString("CreateTable_Files", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CREATE TABLE &quot;Folders&quot; 
        ///(
        ///    &quot;Id&quot; INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL ,
        ///    &quot;Name&quot; NVARCHAR(100),
        ///    &quot;Path&quot; NVARCHAR(1000),
        ///    &quot;IconPath&quot; NVARCHAR(1000),
        ///    &quot;Comment&quot; NVARCHAR(2000),
        ///    &quot;Shortcut&quot; NVARCHAR(20),
        ///    &quot;GroupId&quot; INT,
        ///    &quot;Error&quot; BOOL DEFAULT (0) ,
        ///    &quot;ShowInContextMenu&quot; BOOL DEFAULT (0) ,
        ///    &quot;ImageIndex&quot; INT,
        ///    &quot;ColorCode&quot; NVARCHAR(20)
        ///).
        /// </summary>
        internal static string CreateTable_Folder {
            get {
                return ResourceManager.GetString("CreateTable_Folder", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CREATE TABLE &quot;Groups&quot; 
        ///(
        ///    &quot;Id&quot; INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL ,
        ///    &quot;Name&quot; NVARCHAR(100)
        ///).
        /// </summary>
        internal static string CreateTable_Groups {
            get {
                return ResourceManager.GetString("CreateTable_Groups", resourceCulture);
            }
        }
    }
}
