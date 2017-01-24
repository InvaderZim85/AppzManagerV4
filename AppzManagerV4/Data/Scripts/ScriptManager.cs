namespace AppzManagerV4.Data.Scripts
{
    public static class ScriptManager
    {
        /// <summary>
        /// Gets the create statement for the app table
        /// </summary>
        public static string CreateTableApp => ScriptFiles.ResourceManager.GetString("CreateTable_App");
        /// <summary>
        /// Gets the create statement for the folder table
        /// </summary>
        public static string CreateTableFolder => ScriptFiles.ResourceManager.GetString("CreateTable_Folder");
        /// <summary>
        /// Gets the create statement for the group table
        /// </summary>
        public static string CreateTableGroup => ScriptFiles.ResourceManager.GetString("CreateTable_Groups");
    }
}
