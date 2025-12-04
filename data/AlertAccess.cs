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
    internal class AlertAccess
    {
        //private AlertAccess alertAccess = new AlertAccess();
        //private System.Windows.Forms.Timer alertTimer;

        private SqliteConnection systemConnection;
        public AlertAccess()
        {
            systemConnection = Database.InitializeSystem();
        }
        public List<Alert> GetAllAlerts()
        {
            const string query = "SELECT * FROM Alerts WHERE Status <> 'Resolved'";
            return systemConnection.Query<Alert>(query).ToList();
        }
        //public bool DeleteAlert(int AlertID)
        //{
        //    const string query = "DELETE FROM Alerts WHERE AlertID = @ID";
        //    int result = systemConnection.Execute(query, new { ID = AlertID });
        //    return result > 0;
        //}
        public void InsertAlert(string Type, string Message, string EntityType, int OwnerUserID)
        {
            string sql = @"
        INSERT INTO Alerts(Type, Message, EntityType, Status, OwnerUserID)
        VALUES (@Type, @Message, @EntityType, 'Unread', @OwnerUserID)";

            systemConnection.Execute(sql, new { Type, Message, EntityType, OwnerUserID });
        }

        public void UpdateAlertStatus(int id, string status)
        {
            string sql = "UPDATE Alerts SET Status=@Status, UpdatedAt=CURRENT_TIMESTAMP WHERE AlertID=@ID";
            systemConnection.Execute(sql, new { Status = status, ID = id });
        }
        public void DeleteAlert(int id)
        {
            string sql = "DELETE FROM Alerts WHERE AlertID=@ID";
            systemConnection.Execute(sql, new { ID = id });
        }
        public void DeleteAllAlert()
        {
            systemConnection.Execute("DELETE FROM Alerts");
        }
    }
}
