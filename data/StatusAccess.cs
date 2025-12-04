using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EyeonOps.database;
using EyeonOps.models;
using Microsoft.Data.Sqlite;
using Dapper;

namespace EyeonOps.data
{
    internal class StatusAccess
    {
        private readonly SqliteConnection realtimeConnection;

        public StatusAccess()
        {
            realtimeConnection = Database.InitializeRealtime();
        }
        public List<OperatorStatus> GetAllOperatorStatuses()
        {
            string query = "SELECT ID, Status, CreatedAt, UpdatedAt FROM OperatorStatuses;";
            var result = realtimeConnection.Query<OperatorStatus>(query).ToList();
            return result;
        }
        public int GetStatusIDByStatus(string Status)
        {
            return realtimeConnection.QueryFirstOrDefault<int>("SELECT ID FROM OperatorStatuses WHERE Status=@Status;", new { Status });
        }

        public int GetOperatorStatusIDByStatusText(string Status)
        {
            return realtimeConnection.QueryFirstOrDefault<int>("SELECT ID FROM OperatorStatuses WHERE LOWER(Status) LIKE LOWER(@Status)", new { Status=$"%{Status}%" });
        }

        public int GetStyleStatusIDByStatusText(string Status)
        {
            return realtimeConnection.QueryFirstOrDefault<int>("SELECT ID FROM StyleStatuses WHERE LOWER(Status) LIKE LOWER(@Status)", new { Status = $"%{Status}%" });
        }

        public string GetStyleStatusByStatusID(int StatusID)
        {
            return realtimeConnection.QueryFirstOrDefault<string>("SELECT Status FROM StyleStatuses WHERE ID = @StatusID", new {StatusID});
        }

        public string GetStyleFinalStatusByStatusID(int StatusID)
        {
            return realtimeConnection.QueryFirstOrDefault<string>("SELECT FinalStatus FROM StyleStatuses WHERE ID = @StatusID", new { StatusID });
        }

        public string GetOperatorStatusByID(int ID)
        {
            return realtimeConnection.QueryFirstOrDefault<string>("SELECT Status FROM OperatorStatuses WHERE ID = @ID", new { ID});
        }
    }
}
