using System;
using System.Data;
using System.Data.SQLite;
using System.IO;
using AppzManagerV4.Data.Scripts;
using Dapper;

namespace AppzManagerV4.Data
{
    public class DatabaseManager
    {
        /// <summary>
        /// Contains the path of the database file
        /// </summary>
        private readonly string _dbFile = Path.Combine(Properties.Settings.Default.BaseFolder, "AppzManager.sqlite");
        /// <summary>
        /// Contains the sql lite connection
        /// </summary>
        private SQLiteConnection _connection;
        /// <summary>
        /// Gets the database connection
        /// </summary>
        public SQLiteConnection Connection
        {
            get
            {
                if (_connection == null || _connection.State == ConnectionState.Broken ||
                    _connection.State == ConnectionState.Closed)
                    CreateConnection();

                return _connection;
            }
        }
        /// <summary>
        /// Creates a new database connection
        /// </summary>
        private void CreateConnection()
        {
            var initDb = false;

            if (!File.Exists(_dbFile))
            {
                SQLiteConnection.CreateFile(_dbFile);
                initDb = true;
            }

            _connection = new SQLiteConnection($"Data Source = {_dbFile};Version = 3");
            _connection.Open();

            if (initDb)
                CreateDatabase();
        }
        /// <summary>
        /// Creates a database if no exists
        /// </summary>
        private void CreateDatabase()
        {
            try
            {
                // App table
                _connection.Execute(ScriptManager.CreateTableApp);
                // folder table
                _connection.Execute(ScriptManager.CreateTableFolder);
                // Group table
                _connection.Execute(ScriptManager.CreateTableGroup);
                // File table
                _connection.Execute(ScriptManager.CreateTableFiles);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
