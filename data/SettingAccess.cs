using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using EyeonOps.database;
using EyeonOps.models;
using Microsoft.Data.Sqlite;

namespace EyeonOps.data
{
    internal class SettingAccess
    {
        private SqliteConnection systemConnection;
        public SettingAccess()
        {
            systemConnection = Database.InitializeSystem();
        }
        public List<Setting> GetAllSettings()
        {
            return systemConnection.Query<Setting>("SELECT * FROM SystemSettings").ToList();
        }
    }
}
