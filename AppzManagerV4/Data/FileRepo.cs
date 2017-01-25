using System.Collections.Generic;
using System.Linq;
using AppzManagerV4.DataObjects;
using Dapper;

namespace AppzManagerV4.Data
{
    public class FileRepo
    {
        /// <summary>
        /// Contains the database manager
        /// </summary>
        private readonly DatabaseManager _dbManager = new DatabaseManager();

        /// <summary>
        /// Gets all files which are stored in the database
        /// </summary>
        /// <returns>The list of files</returns>
        public List<FileModel> GetFiles()
        {
            const string query = "SELECT Id, Name, Path, Comment, Shortcut, " +
                                 "GroupId, Error, ShowInContextMenu, ImageIndex, ColorCode " +
                                 "FROM Files";

            return _dbManager.Connection.Query<FileModel>(query).ToList();
        }
        /// <summary>
        /// Gets all files according to their group id
        /// </summary>
        /// <param name="groupId">The group id</param>
        /// <returns>The list of files</returns>
        public List<FileModel> GetFiles(int groupId)
        {
            const string query = "SELECT Id, Name, Path, Comment, Shortcut, " +
                                 "GroupId, Error, ShowInContextMenu, ImageIndex, ColorCode " +
                                 "FROM Files " +
                                 "WHERE GroupId = @groupId";

            return _dbManager.Connection.Query<FileModel>(query, new { groupId }).ToList();
        }
        /// <summary>
        /// Adds a file
        /// </summary>
        /// <param name="file">The file</param>
        /// <returns>true if successful, otherwise false</returns>
        public bool AddFile(FileModel file)
        {
            const string query = "INSERT INTO Files (Name, Path, Comment, Shortcut, " +
                                 "GroupId, Error, ShowInContextMenu, ImageIndex, ColorCode) " +
                                 "VALUES (@name, @path, @comment, @shortcut, @groupId, " +
                                 "@error, @showInContextMenu, @imageIndex, @colorCode)";

            return _dbManager.Connection.Execute(query, new
            {
                name = file.Name,
                path = file.Path,
                comment = file.Comment,
                shortcut = file.Shortcut,
                groupId = file.GroupId,
                error = file.Error,
                showInContextMenu = file.ShowInContextMenu,
                imageIndex = file.ImageIndex,
                colorCode = file.ColorCode
            }) > 0;
        }
        /// <summary>
        /// Updates an existing file entry
        /// </summary>
        /// <param name="file">The file</param>
        /// <returns>true if successful, otherwise false</returns>
        public bool UpdateFile(FileModel file)
        {
            const string query = "UPDATE Files " +
                                 "SET Name = @name, " +
                                 "Path = @path, " +
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
                name = file.Name,
                path = file.Path,
                comment = file.Comment,
                shortcut = file.Shortcut,
                groupId = file.GroupId,
                error = file.Error,
                showInContextMenu = file.ShowInContextMenu,
                imageIndex = file.ImageIndex,
                colorCode = file.ColorCode,
                id = file.Id
            }) > 0;
        }
        /// <summary>
        /// Deletes an existing entry
        /// </summary>
        /// <param name="id">The id of the file entry</param>
        /// <returns>true if successful, otherwise false</returns>
        public bool DeleteFile(int id)
        {
            const string query = "DELETE FROM Files WHERE Id = @id";

            return _dbManager.Connection.Execute(query, new { id }) > 0;
        }
    }
}
