﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.1426
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.VisualStudio.Text.BufferUndoManager.Implementation {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Strings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Strings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.VisualStudio.Text.Implementation.Text.Impl.TextBufferUndoManager.Strings", typeof(Strings).Assembly);
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
        ///   Looks up a localized string similar to Cannot redo this change..
        /// </summary>
        internal static string CannotRedo {
            get {
                return ResourceManager.GetString("CannotRedo", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot undo this change..
        /// </summary>
        internal static string CannotUndo {
            get {
                return ResourceManager.GetString("CannotUndo", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Create Read Only Region.
        /// </summary>
        internal static string ReadOnlyRegionCreated {
            get {
                return ResourceManager.GetString("ReadOnlyRegionCreated", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Remove Read Only Region.
        /// </summary>
        internal static string ReadOnlyRegionRemoved {
            get {
                return ResourceManager.GetString("ReadOnlyRegionRemoved", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Text Buffer Change.
        /// </summary>
        internal static string TextBufferChanged {
            get {
                return ResourceManager.GetString("TextBufferChanged", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to TextVersion has no associated changes.
        /// </summary>
        internal static string TextVersionNoChanges {
            get {
                return ResourceManager.GetString("TextVersionNoChanges", resourceCulture);
            }
        }
    }
}