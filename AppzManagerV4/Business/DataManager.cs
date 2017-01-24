using System.Collections.Generic;
using AppzManagerV4.Data;
using AppzManagerV4.DataObjects;

namespace AppzManagerV4.Business
{
    public class DataManager
    {
        /// <summary>
        /// Contains the app repo
        /// </summary>
        private readonly AppRepo _repoApp = new AppRepo();
        /// <summary>
        /// Contains the folder repo
        /// </summary>
        private readonly FolderRepo _repoFolder = new FolderRepo();
        /// <summary>
        /// Contains the group repo
        /// </summary>
        private readonly GroupRepo _repoGroup = new GroupRepo();

        #region App 
        /// <summary>
        /// Gets all apps
        /// </summary>
        /// <returns>List of apps</returns>
        public List<AppModel> GetApps()
        {
            return _repoApp.GetApps();
        }
        /// <summary>
        /// Gets all apps according to theier group id
        /// </summary>
        /// <param name="groupId">The group id</param>
        /// <returns>List of apps</returns>
        public List<AppModel> GetApps(int groupId)
        {
            return _repoApp.GetApps(groupId);
        }
        /// <summary>
        /// Saves an app
        /// </summary>
        /// <param name="app">The app</param>
        /// <returns>true if successful, otherwise false</returns>
        public bool SaveApp(AppModel app)
        {
            if (app.Id == 0)
                return _repoApp.AddApp(app);
            else
                return _repoApp.UpdateApp(app);
        }
        /// <summary>
        /// Deletes an app
        /// </summary>
        /// <param name="app">The app</param>
        /// <returns>true if successful, otherwise false</returns>
        public bool DeleteApp(AppModel app)
        {
            return _repoApp.DeleteApp(app.Id);
        }
        /// <summary>
        /// Deletes an app
        /// </summary>
        /// <param name="id">The id of the app</param>
        /// <returns>true if successful, otherwise false</returns>
        public bool DeleteApp(int id)
        {
            return _repoApp.DeleteApp(id);
        }
        #endregion

        #region Folder
        /// <summary>
        /// Gets all folders
        /// </summary>
        /// <returns>List of folders</returns>
        public List<FolderModel> GetFolder()
        {
            return _repoFolder.GetFolders();
        }
        /// <summary>
        /// Gets all folders according to their group id
        /// </summary>
        /// <param name="groupId">The group id</param>
        /// <returns>List of folders</returns>
        public List<FolderModel> GetFolder(int groupId)
        {
            return _repoFolder.GetFolders(groupId);
        }
        /// <summary>
        /// Saves a folder
        /// </summary>
        /// <param name="folder">The folder</param>
        /// <returns>true if successful, otherwise false</returns>
        public bool SaveFolder(FolderModel folder)
        {
            if (folder.Id == 0)
                return _repoFolder.AddFolder(folder);
            else
                return _repoFolder.UpdateApp(folder);
        }
        /// <summary>
        /// Deletes a folder
        /// </summary>
        /// <param name="folder">The folder</param>
        /// <returns>true if successful, otherwise false</returns>
        public bool DeleteFolder(FolderModel folder)
        {
            return _repoFolder.DeleteFolder(folder.Id);
        }
        /// <summary>
        /// Deletes a folder
        /// </summary>
        /// <param name="id">The id of the folder</param>
        /// <returns>true if successful, otherwise false</returns>
        public bool DeleteFolder(int id)
        {
            return _repoFolder.DeleteFolder(id);
        }
        #endregion

        #region Group
        /// <summary>
        /// Gets all groups
        /// </summary>
        /// <returns>List of groups</returns>
        public List<GroupModel> GetGroups()
        {
            return _repoGroup.GetGroups() ?? new List<GroupModel>();
        }
        /// <summary>
        /// Saves a group
        /// </summary>
        /// <param name="group">The group</param>
        /// <returns>true if successful, otherwise false</returns>
        public bool SaveGroup(GroupModel group)
        {
            if (group.Id == 0)
                return _repoGroup.AddGroup(group);
            else
                return _repoGroup.UpdateGroup(group);
        }
        /// <summary>
        /// Saves a list of groups
        /// </summary>
        /// <param name="groupList">The group list</param>
        /// <returns>true if successful, otherwise false</returns>
        public bool SaveGroupList(IEnumerable<GroupModel> groupList)
        {
            var result = true;

            foreach (var group in groupList)
            {
                if (!SaveGroup(group))
                    result = false;
            }

            return result;
        }
        /// <summary>
        /// Checks if a group is in use
        /// </summary>
        /// <param name="id">The if of the group</param>
        /// <returns>true if the group is still in use, otherwise false</returns>
        public bool GroupInUse(int id)
        {
            return _repoGroup.GroupInUse(id);
        }
        /// <summary>
        /// Deletes a group
        /// </summary>
        /// <param name="group">The group</param>
        /// <returns>true if successful, otherwise false</returns>
        public bool DeleteGroup(GroupModel group)
        {
            return _repoGroup.DeleteGroup(group.Id);
        }
        #endregion
    }
}
