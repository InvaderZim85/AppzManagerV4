using System.IO;

namespace AppzManagerV4.DataObjects
{
    public class FileModel
    {
        /// <summary>
        /// Gets or sets the file info
        /// </summary>
        public FileInfo FileInfo { get; }

        /// <summary>
        /// Returns the name of the file
        /// </summary>
        /// <returns>The name of the file</returns>
        public override string ToString()
        {
            return FileInfo?.Name ?? "";
        }
        /// <summary>
        /// Creates a new instance of the class
        /// </summary>
        /// <param name="fileInfo">The fileinfo</param>
        public FileModel(FileInfo fileInfo)
        {
            FileInfo = fileInfo;
        }
    }
}
