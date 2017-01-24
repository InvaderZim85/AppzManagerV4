using System.Collections.Generic;
using System.Linq;
using AppzManagerV4.DataObjects;
using Dapper;

namespace AppzManagerV4.Data
{
    public class GroupRepo
    {
        /// <summary>
        /// Contains the database manager
        /// </summary>
        private readonly DatabaseManager _dbManager = new DatabaseManager();

        /// <summary>
        /// Gets all groups
        /// </summary>
        /// <returns>List of groups</returns>
        public List<GroupModel> GetGroups()
        {
            const string query = "SELECT Id, Name FROM Groups";

            return _dbManager.Connection.Query<GroupModel>(query).ToList();
        }
        /// <summary>
        /// Adds a new group
        /// </summary>
        /// <param name="group">The group</param>
        /// <returns>true if successful, otherwise false</returns>
        public bool AddGroup(GroupModel group)
        {
            const string query = "INSERT INTO Groups (Name) VALUES (@name)";

            return _dbManager.Connection.Execute(query, new {name = group.Name}) > 0;
        }
        /// <summary>
        /// Updates a group
        /// </summary>
        /// <param name="group">The group</param>
        /// <returns>true if successful, otherwise false</returns>
        public bool UpdateGroup(GroupModel group)
        {
            const string query = "UPDATE Groups SET Name = @name WHERE Id = @id";

            return _dbManager.Connection.Execute(query, new
            {
                name = group.Name,
                id = group.Id
            }) > 0;
        }
        /// <summary>
        /// Deletes a group
        /// </summary>
        /// <param name="id">The id</param>
        /// <returns>true if successful, otherwise false</returns>
        public bool DeleteGroup(int id)
        {
            const string query = "DELETE FROM Groups WHERE Id = @id";

            return _dbManager.Connection.Execute(query, new {id}) > 0;
        }
        /// <summary>
        /// Checks if the grop is in use
        /// </summary>
        /// <param name="id">The id of the group</param>
        /// <returns>true if the group is still used, otherwise false</returns>
        public bool GroupInUse(int id)
        {
            const string queryApp = "SELECT COUNT(*) FROM Apps WHERE GroupId = @id";
            const string queryFolder = "SELECT COUNT(*) FROM Folders WHERE GroupId = @id";

            var countApp = _dbManager.Connection.QuerySingle<int>(queryApp, new {id});
            var countFolder = _dbManager.Connection.QuerySingle<int>(queryFolder, new {id});

            return (countApp + countFolder) > 0;
        }
    }
}
