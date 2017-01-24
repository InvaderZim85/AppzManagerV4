using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppzManagerV4.Global
{
    public static class GlobalEnums
    {
        /// <summary>
        /// The Regiontypes
        /// </summary>
        public enum RegionType
        {
            /// <summary>
            /// Application
            /// </summary>
            App,
            /// <summary>
            /// Group
            /// </summary>
            Group,
            /// <summary>
            /// Folder
            /// </summary>
            Folder,
            /// <summary>
            /// File
            /// </summary>
            File,
            /// <summary>
            /// Default
            /// </summary>
            None
        }
        /// <summary>
        /// The return types
        /// </summary>
        public enum ReturnType
        {
            /// <summary>
            /// Success
            /// </summary>
            Success,
            /// <summary>
            /// Error
            /// </summary>
            Error,
            /// <summary>
            /// Entry already exists
            /// </summary>
            AlreadyExisting,
            /// <summary>
            /// Default
            /// </summary>
            None
        }
        /// <summary>
        /// The different keydown events
        /// </summary>
        public enum KeyDownEvent
        {
            /// <summary>
            /// New application
            /// </summary>
            NewApp,
            /// <summary>
            /// New folder
            /// </summary>
            NewFolder,
            /// <summary>
            /// Default
            /// </summary>
            None
        }
    }
}
