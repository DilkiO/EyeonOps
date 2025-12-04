using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using EyeonOps.database;
using Microsoft.Data.Sqlite;

namespace EyeonOps.data
{
    internal class OperatorLogsAccess
    {
        private readonly SqliteConnection realtimeConnection;
        public OperatorLogsAccess()
        {
            realtimeConnection = Database.InitializeRealtime();
        }

        public void LogStyleChanges(int OperatorID, string OperatorEPFName, int OperatorStatusID, DateTime StatusChangedDateTime)
        {
            realtimeConnection.Execute(@"INSERT INTO OperatorLogs(OperatorID,OperatorEPFName, OperatorStatusID, StatusUpdateDateTime) 
            VALUES(@OperatorID, @OperatorEPFName, @OperatorStatusID, @StatusChangedDateTime)", new { OperatorID, OperatorEPFName, OperatorStatusID, StatusChangedDateTime});
        }
    }
}
