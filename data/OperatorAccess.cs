using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using EyeonOps.database;
using EyeonOps.models;
using Microsoft.Data.Sqlite;

namespace EyeonOps.data
{
    public class OperatorAccess
    {
        public Operator getoperatorbyID(int ID)
        {
            return realtimeConnection.QueryFirstOrDefault<Operator>("SELECT * FROM Operators WHERE ID=@ID", new { ID });
        }
        public Operator getoperatorbyEPFName(string EPFName)
        {
            return realtimeConnection.QueryFirstOrDefault<Operator>("SELECT * FROM Operators WHERE OperatorEPFName=@EPFName",new{EPFName});
        }

        public List<Operator> GetIdleOperatorsData()
        {
            return realtimeConnection.Query<Operator>("SELECT o.* FROM Operators o JOIN OperatorStatuses os ON o.StatusID = os.ID WHERE os.Status='Idle'").ToList();
        }

        private readonly SqliteConnection realtimeConnection;

        public OperatorAccess()
        {
            realtimeConnection = Database.InitializeRealtime();
        }

        public bool AddNewOperatorsBulk(List<Operator> operators)
        {
            if (operators == null || operators.Count == 0)
                return false;

            const string query = @"
        INSERT INTO Operators
        (OperatorEPFName, EPF, Name, SampleRoom, Grade, Sequence, JoinDate, StatusID, StatusUpdateDateTime)
        VALUES (@OperatorEPFName, @EPF, @Name, @SampleRoom, @Grade, @Sequence, @JoinDate, @StatusID, @StatusUpdateDateTime);";

            int successCount = 0;
            var skippedOperators = new List<string>();

            using (var connection = realtimeConnection)
            {
                connection.Open();

                foreach (var op in operators)
                {
                    Debug.WriteLine(op.StatusID);
                    try
                    {
                        //op.OperatorEPFName = $"{op.EPF}-{op.Name.Split(' ')[0]}";
                        successCount += connection.Execute(query, op);
                    }
                    catch (SqliteException ex) when (ex.SqliteErrorCode == 19)
                    {
                        skippedOperators.Add(op.OperatorEPFName);
                    }
                }
            }

            if (skippedOperators.Any())
            {
                string skippedList = string.Join("\n", skippedOperators);
                MessageBox.Show(
                    $"The following operators were skipped (duplicates found):\n\n{skippedList}",
                    "Duplicate Operators Skipped",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }

            return successCount > 0;
        }
        public bool AddNewOperator(Operator op)
        {
            int defaultsatatusid = new StatusAccess().GetStatusIDByStatus("Idle");
            var parameters = new
            {
                OperatorEPFName = $"{op.EPF}-{op.Name.Split(" ")[0]}",
                op.EPF,
                op.Name,
                op.SampleRoom,
                op.Grade,
                op.Sequence,
                op.JoinDate,
                StatusID=defaultsatatusid
            };

            int rowsAffected = realtimeConnection.Execute(@"
                INSERT INTO Operators 
                (OperatorEPFName, EPF, Name, SampleRoom, Grade, Sequence, JoinDate, StatusID, StatusUpdateDateTime)
                VALUES 
                (@OperatorEPFName, @EPF, @Name, @SampleRoom, @Grade, @Sequence, @JoinDate, @StatusID, CURRENT_TIMESTAMP);", parameters);
            return rowsAffected > 0;
        }
        public List<Operator> GetAllOperatorData()
        {
            List<Operator> Operator = realtimeConnection.Query<Operator>("SELECT * FROM Operators ORDER BY ID;").ToList();

               return Operator;
        }
        public bool UpdateOperator(Operator updatedOperator)
        {
                const string sql = @"UPDATE Operators SET 
                     OperatorEPFName=@OperatorEPFName,Name = @Name,SampleRoom = @SampleRoom,Grade = @Grade,Sequence = @Sequence,JoinDate = @JoinDate,UpdatedAt = CURRENT_TIMESTAMP WHERE ID = @ID;";

            int rowsAffected = realtimeConnection.Execute(sql, new
                {
                    updatedOperator.Name,
                    OperatorEPFName = $"{updatedOperator.EPF}-{updatedOperator.Name.Split(" ")[0]}",
                    updatedOperator.SampleRoom,
                    updatedOperator.Grade,
                    updatedOperator.Sequence,
                    updatedOperator.JoinDate,
                    updatedOperator.ID
                });

                return rowsAffected > 0;
        }
        public bool DeleteOperator(int ID)
        {
            try
            {
                int affected = realtimeConnection.Execute("DELETE FROM Operators WHERE ID = @ID;", new { ID });
                return affected > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Error deleting operator:\n\n{ex.Message}",
                    "Delete Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return false;
            }
        }
        public bool UpdateOperatorStatus(int ID, int StatusID)
        {
            try
            {
                DateTime StatusUpdateDateTime=DateTime.UtcNow;
                int affected = realtimeConnection.Execute(
                    "UPDATE Operators SET StatusID = @StatusID, StatusUpdateDateTime = @StatusUpdateDateTime, UpdatedAt = CURRENT_TIMESTAMP WHERE ID = @ID;",
                    new { ID, StatusID, StatusUpdateDateTime }
                );
                string OperatorEPFName= getoperatorEpfNamebyID(ID);
                new OperatorLogsAccess().LogStyleChanges(ID, OperatorEPFName, StatusID, StatusUpdateDateTime);
                return affected > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Error updating operator status:\n\n{ex.Message}",
                    "Update Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return false;
            }
        }

        public bool UpdateOperatorStatusByStatusName(int ID, string Status)
        {
            //Debug.WriteLine(ID + " - " + Status);
            int result = realtimeConnection.Execute("UPDATE Operators SET StatusID = (SELECT os.ID FROM OperatorStatuses os WHERE os.Status = @Status) WHERE ID = @ID;", new { ID, Status });

            return result > 0;
        }
        public string getoperatorEpfNamebyID(int ID)
        {
            return realtimeConnection.QueryFirstOrDefault<string>("SELECT OperatorEPFName FROM Operators WHERE ID=@ID;", new { ID });
        }
        public Dashboard GetOperatorCounts()
        {
            string query = @"SELECT COUNT(*) AS Total,SUM(CASE WHEN os.Status = 'Idle' THEN 1 ELSE 0 END) AS Idle,SUM(CASE WHEN os.Status = 'Active' THEN 1 ELSE 0 END) AS Active,
            SUM(CASE WHEN os.Status = 'Waiting' THEN 1 ELSE 0 END) AS Waiting FROM Operators o LEFT JOIN OperatorStatuses os ON o.StatusID = os.ID;";
            return realtimeConnection.Query<Dashboard>(query).FirstOrDefault();
        }
    }
}
