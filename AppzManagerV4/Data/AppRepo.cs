using System.Collections.Generic;
using System.Linq;
using AppzManagerV4.DataObjects;
using Dapper;

namespace AppzManagerV4.Data
{
    public class AppRepo
    {
        /// <summary>
        /// Contains the database manager
        /// </summary>
        private readonly DatabaseManager _dbManager = new DatabaseManager();

        /// <summary>
        /// Gets all apps which are stored in the database
        /// </summary>
        /// <returns>The list of apps</returns>
        public List<AppModel> GetApps()
        {
            const string query = "SELECT Id, Name, Path, IconPath, Comment, Shortcut, " +
                                 "GroupId, Error, ShowInContextMenu, ImageIndex, ColorCode, ExecuteIn, " +
                                 "Version, Parameter, Autostart " +
                                 "FROM Apps";

            return _dbManager.Connection.Query<AppModel>(query).ToList();
        }
        /// <summary>
        /// Gets all apps according to their group id
        /// </summary>
        /// <param name="groupId">The group id</param>
        /// <returns>The list of apps</returns>
        public List<AppModel> GetApps(int groupId)
        {
            const string query = "SELECT Id, Name, Path, IconPath, Comment, Shortcut, " +
                                 "GroupId, Error, ShowInContextMenu, ImageIndex, ColorCode, ExecuteIn, " +
                                 "Version, Parameter, Autostart " +
                                 "FROM Apps " +
                                 "WHERE GroupId = @groupId";

            return _dbManager.Connection.Query<AppModel>(query, new {groupId}).ToList();
        }
        /// <summary>
        /// Adds an app
        /// </summary>
        /// <param name="app">The app</param>
        /// <returns>true if successful, otherwise false</returns>
        public bool AddApp(AppModel app)
        {
            const string query = "INSERT INTO Apps (Name, Path, IconPath, Comment, Shortcut, " +
                                 "GroupId, Error, ShowInContextMenu, ImageIndex, ColorCode, ExecuteIn, " +
                                 "Version, Parameter, Autostart) VALUES (@name, @path, @iconPath, " +
                                 "@comment, @shortcut, @groupId, @error, @showInContextMenu, @imageIndex, " +
                                 "@colorCode, @executeIn, @version, @parameter, @autostart)";

            return _dbManager.Connection.Execute(query, new
            {
                name = app.Name,
                path = app.Path,
                iconPath = app.IconPath,
                comment = app.Comment,
                shortcut = app.Shortcut,
                groupId = app.GroupId,
                error = app.Error,
                showInContextMenu = app.ShowInContextMenu,
                imageIndex = app.ImageIndex,
                colorCode = app.ColorCode,
                executeIn = app.ExecuteIn,
                version = app.Version,
                parameter = app.Parameter,
                autostart = app.Autostart
            }) > 0;
        }
        /// <summary>
        /// Updates an existing app entry
        /// </summary>
        /// <param name="app">The app</param>
        /// <returns>true if successful, otherwise false</returns>
        public bool UpdateApp(AppModel app)
        {
            const string query = "UPDATE Apps " +
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
                                 "ExecuteIn = @executeIn, " +
                                 "Version = @version, " +
                                 "Parameter = @parameter, " +
                                 "Autostart = @autostart " +
                                 "WHERE Id = @id";

            return _dbManager.Connection.Execute(query, new
            {
                name = app.Name,
                path = app.Path,
                iconPath = app.IconPath,
                comment = app.Comment,
                shortcut = app.Shortcut,
                groupId = app.GroupId,
                error = app.Error,
                showInContextMenu = app.ShowInContextMenu,
                imageIndex = app.ImageIndex,
                colorCode = app.ColorCode,
                executeIn = app.ExecuteIn,
                version = app.Version,
                parameter = app.Parameter,
                autostart = app.Autostart,
                id = app.Id
            }) > 0;
        }
        /// <summary>
        /// Deletes an existing entry
        /// </summary>
        /// <param name="id">The id of the app entry</param>
        /// <returns>true if successful, otherwise false</returns>
        public bool DeleteApp(int id)
        {
            const string query = "DELETE FROM Apps WHERE Id = @id";

            return _dbManager.Connection.Execute(query, new {id}) > 0;
        }
    }
}
