using System.Collections.Generic;
using System.Linq;
using AppzManagerV4.DataObjects;
using Dapper;

namespace AppzManagerV4.Data
{
    public class FolderRepo
    {
        /// <summary>
        /// Contains the database manager
        /// </summary>
        private readonly DatabaseManager _dbManager = new DatabaseManager();

        /// <summary>
        /// Gets all folders which are stored in the database
        /// </summary>
        /// <returns>The list of folders</returns>
        public List<FolderModel> GetFolders()
        {
            const string query = "SELECT Id, Name, Path, IconPath, Comment, Shortcut, " +
                                 "GroupId, Error, ShowInContextMenu, ImageIndex, ColorCode " +
                                 "FROM Folders";

            return _dbManager.Connection.Query<FolderModel>(query).ToList();
        }
        /// <summary>
        /// Gets all folders according to their group id
        /// </summary>
        /// <param name="groupId">The group id</param>
        /// <returns>The list of folders</returns>
        public List<FolderModel> GetFolders(int groupId)
        {
            const string query = "SELECT Id, Name, Path, IconPath, Comment, Shortcut, " +
                                 "GroupId, Error, ShowInContextMenu, ImageIndex, ColorCode " + 
                                 "FROM Folders " +
                                 "WHERE GroupId = @groupId";

            return _dbManager.Connection.Query<FolderModel>(query, new { groupId }).ToList();
        }
        /// <summary>
        /// Adds a folder
        /// </summary>
        /// <param name="folder">The folder</param>
        /// <returns>true if successful, otherwise false</returns>
        public bool AddFolder(FolderModel folder)
        {
            const string query = "INSERT INTO Folders (Name, Path, IconPath, Comment, Shortcut, " +
                                 "GroupId, Error, ShowInContextMenu, ImageIndex, ColorCode) " +
                                 "VALUES (@name, @path, @iconPath, @comment, @shortcut, @groupId, " +
                                 "@error, @showInContextMenu, @imageIndex, @colorCode)";

            return _dbManager.Connection.Execute(query, new
            {
                name = folder.Name,
                path = folder.Path,
                iconPath = folder.IconPath,
                comment = folder.Comment,
                shortcut = folder.Shortcut,
                groupId = folder.GroupId,
                error = folder.Error,
                showInContextMenu = folder.ShowInContextMenu,
                imageIndex = folder.ImageIndex,
                colorCode = folder.ColorCode
            }) > 0;
        }
        /// <summary>
        /// Updates an existing folder entry
        /// </summary>
        /// <param name="folder">The folder</param>
        /// <returns>true if successful, otherwise false</returns>
        public bool UpdateFolder(FolderModel folder)
        {
            const string query = "UPDATE Folders " +
                                 "SET Name = @name, " +
                                 "Path = @path, " +
                                 "IconPath = @iconPath, " +
                                 "Comment = @comment, " +
                                 "Shortcut = @shortcut, " +
                                 "GroupId = @groupId, " +
                                 "Error = @error, " +
                                 "ShowInContextMenu = @showInContextMenu, " +
                                 "ImageIndex = @imageIndex, " +
                                 "ColorCode = @colorCode, " +
                                 "WHERE Id = @id";

            return _dbManager.Connection.Execute(query, new
            {
                name = folder.Name,
                path = folder.Path,
                iconPath = folder.IconPath,
                comment = folder.Comment,
                shortcut = folder.Shortcut,
                groupId = folder.GroupId,
                error = folder.Error,
                showInContextMenu = folder.ShowInContextMenu,
                imageIndex = folder.ImageIndex,
                colorCode = folder.ColorCode,
                id = folder.Id
            }) > 0;
        }
        /// <summary>
        /// Deletes an existing entry
        /// </summary>
        /// <param name="id">The id of the folder entry</param>
        /// <returns>true if successful, otherwise false</returns>
        public bool DeleteFolder(int id)
        {
            const string query = "DELETE FROM Folders WHERE Id = @id";

            return _dbManager.Connection.Execute(query, new { id }) > 0;
        }
    }
}
