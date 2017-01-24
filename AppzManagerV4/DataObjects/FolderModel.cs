namespace AppzManagerV4.DataObjects
{
    public class FolderModel
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
        /// Gets ors sets the path
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
        /// Gets or sets the error indicator
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
        public string ColorCode { get; set; }
    }
}
