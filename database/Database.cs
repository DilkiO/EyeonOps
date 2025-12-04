using Microsoft.Data.Sqlite;

namespace EyeonOps.database
{
    internal class Database
    {
        private static string connectionStringSystem = "Data source=database\\system.db";
        private static string connectionStringRealtime = "Data source=database\\realtime.db";

        public static SqliteConnection InitializeSystem()
        { 
            return new SqliteConnection(connectionStringSystem);
        }
        public static SqliteConnection InitializeRealtime()
        {
            return new SqliteConnection(connectionStringRealtime);
        }
    }
}
