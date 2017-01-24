using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppzManagerV4.DataObjects
{
    public class ImportAppModel
    {
        /// <summary>
        /// Gets or sets the id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Gets or sets the name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Gets or sets the path
        /// </summary>
        public string Path { get; set; }
        /// <summary>
        /// Gets or sets the icon path
        /// </summary>
        public string IconPath { get; set; }
        /// <summary>
        /// Gets or sets the comment
        /// </summary>
        public string Comment { get; set; }
        /// <summary>
        /// Gets or sets the shortcut
        /// </summary>
        public string Shortcut { get; set; }
        /// <summary>
        /// Gets or sets the group id
        /// </summary>
        public int GroupId { get; set; }
        /// <summary>
        /// Gets or sets the error value
        /// </summary>
        public bool Error { get; set; }
        /// <summary>
        /// Gets or sets the show in context menu value
        /// </summary>
        public bool ShowInContextMenu { get; set; }
        /// <summary>
        /// Gets or sets the image index
        /// </summary>
        public int ImageIndex { get; set; }
        /// <summary>
        /// Gets or sets the context color
        /// </summary>
        public Color ContextColor { get; set; }
        /// <summary>
        /// Gets or sets the execute in path
        /// </summary>
        public string ExecuteIn { get; set; }
        /// <summary>
        /// Gets or sets the version
        /// </summary>
        public string Version { get; set; }
        /// <summary>
        /// Gets or sets the parameter
        /// </summary>
        public string Parameter { get; set; }
        /// <summary>
        /// Gets or sets the autostart value
        /// </summary>
        public bool Autostart { get; set; }
    }

    public class ImportFolderModel
    {
        /// <summary>
        /// Gets or sets the id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Gets or sets the name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Gets or sets the path
        /// </summary>
        public string Path { get; set; }
        /// <summary>
        /// Gets or sets the icon path
        /// </summary>
        public string IconPath { get; set; }
        /// <summary>
        /// Gets or sets the comment
        /// </summary>
        public string Comment { get; set; }
        /// <summary>
        /// Gets or sets the shortcut
        /// </summary>
        public string Shortcut { get; set; }
        /// <summary>
        /// Gets or sets the group id
        /// </summary>
        public int GroupId { get; set; }
        /// <summary>
        /// Gets or sets the error value
        /// </summary>
        public bool Error { get; set; }
        /// <summary>
        /// Gets or sets the show in context menu value
        /// </summary>
        public bool ShowInContextMenu { get; set; }
        /// <summary>
        /// Gets or sets the image index
        /// </summary>
        public int ImageIndex { get; set; }
        /// <summary>
        /// Gets or sets the context color
        /// </summary>
        public Color ContextColor { get; set; }
    }
}
