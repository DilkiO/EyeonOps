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
    internal class StyleAccess
    {
        public List<Style> GetHandOverStyles()
        {
            return realtimeConnection.Query<Style>("SELECT Styles.SampleRequestNo, Styles.Customer, Styles.SampleFitType, Styles.StyleNo, Styles.Quantity, Styles.Priority, Styles.CurrentStage, ss.Status AS StatusName, Styles.StatusUpdateDateTime, Styles.TotalCountofOperations, Styles.PlannedStartDateTime, Styles.ActualStartDateTime, Styles.PlannedFinishDateTime, Styles.ActualFinishDateTime, Styles.CreatedAt, Styles.UpdatedAt FROM Styles JOIN StyleStatuses ss ON ss.ID=Styles.StatusID WHERE ss.Status='H/O TO SAMPLE ROOM'").ToList();
        }
        private object SafeDbNull(object value)
        {
            if (value == null)
                return DBNull.Value;

            if (value is string s && string.IsNullOrWhiteSpace(s))
                return DBNull.Value;

            return value;
        }
        private SqliteConnection realtimeConnection;
        public StyleAccess()
        {
            realtimeConnection = Database.InitializeRealtime();
        }
        public bool updateStyleStatusBySrNumber(string SRnumber, int StatusID)
        {
            int result = realtimeConnection.Execute("UPDATE Styles SET StatusID=@StatusID WHERE SampleRequestNo=@SRnumber", new { SRnumber , StatusID });
            return result > 0;
        }
        public bool AddNewStylesBulk(List<Style> styles)
        {
            if (styles == null || styles.Count == 0) return false;

            var failedStyles = new List<string>();

            using (var connection = realtimeConnection)
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    foreach (var style in styles)
                    {
                        Debug.WriteLine(style.StatusID);
                        // Try INSERT
                        try
                        {
                            string insertQuery = @"INSERT INTO Styles 
                                (SampleRequestNo, Customer, SampleFitType, StyleNo, Quantity, Priority, CurrentStage, StatusID,
                                 StatusUpdateDateTime, TotalCountofOperations, PlannedStartDateTime, ActualStartDateTime,
                                 PlannedFinishDateTime, ActualFinishDateTime)
                            VALUES
                                (@SampleRequestNo, @Customer, @SampleFitType, @StyleNo, @Quantity, @Priority, @CurrentStage,
                                 @StatusID, @StatusUpdateDateTime, @TotalCountofOperations, @PlannedStartDateTime, 
                                 @ActualStartDateTime, @PlannedFinishDateTime, @ActualFinishDateTime);";

                            using (var sqlquery = connection.CreateCommand())
                            {
                                sqlquery.CommandText = insertQuery;
                                sqlquery.Parameters.AddWithValue("@SampleRequestNo",SafeDbNull(style.SampleRequestNo));
                                sqlquery.Parameters.AddWithValue("@Customer", SafeDbNull(style.Customer));
                                sqlquery.Parameters.AddWithValue("@SampleFitType", SafeDbNull(style.SampleFitType));
                                sqlquery.Parameters.AddWithValue("@StyleNo", SafeDbNull(style.StyleNo));
                                sqlquery.Parameters.AddWithValue("@Quantity", SafeDbNull(style.Quantity));
                                sqlquery.Parameters.AddWithValue("@Priority", SafeDbNull(style.Priority));
                                sqlquery.Parameters.AddWithValue("@CurrentStage", SafeDbNull(style.CurrentStage));
                                sqlquery.Parameters.AddWithValue("@StatusID", SafeDbNull(style.StatusID));
                                sqlquery.Parameters.AddWithValue("@StatusUpdateDateTime", SafeDbNull(style.StatusUpdateDateTime));
                                sqlquery.Parameters.AddWithValue("@TotalCountofOperations", SafeDbNull(style.TotalCountofOperations));
                                sqlquery.Parameters.AddWithValue("@PlannedStartDateTime", SafeDbNull(style.PlannedStartDateTime));
                                sqlquery.Parameters.AddWithValue("@ActualStartDateTime", SafeDbNull(style.ActualStartDateTime));
                                sqlquery.Parameters.AddWithValue("@PlannedFinishDateTime", SafeDbNull(style.PlannedFinishDateTime));
                                sqlquery.Parameters.AddWithValue("@ActualFinishDateTime", SafeDbNull(style.ActualFinishDateTime));
                                sqlquery.ExecuteNonQuery();
                            }
                        }
                        // If duplicate, try UPDATE
                        catch (SqliteException ex) when (ex.SqliteErrorCode == 19)
                        {
                            try
                            {
                                string updateQuery = @"UPDATE Styles SET
                                    Customer = @Customer,
                                    SampleFitType = @SampleFitType,
                                    StyleNo = @StyleNo,
                                    Quantity = @Quantity,
                                    Priority = @Priority,
                                    CurrentStage = @CurrentStage,
                                    StatusID = @StatusID,
                                    StatusUpdateDateTime = @StatusUpdateDateTime,
                                    TotalCountofOperations = @TotalCountofOperations,
                                    PlannedStartDateTime = @PlannedStartDateTime,
                                    ActualStartDateTime = @ActualStartDateTime,
                                    PlannedFinishDateTime = @PlannedFinishDateTime,
                                    ActualFinishDateTime = @ActualFinishDateTime,
                                    UpdatedAt=CURRENT_TIMESTAMP WHERE SampleRequestNo = @SampleRequestNo;";

                                using (var sqlquery = connection.CreateCommand())
                                {
                                    sqlquery.CommandText = updateQuery;
                                    sqlquery.Parameters.AddWithValue("@SampleRequestNo", SafeDbNull(style.SampleRequestNo));
                                    sqlquery.Parameters.AddWithValue("@Customer", SafeDbNull(style.Customer));
                                    sqlquery.Parameters.AddWithValue("@SampleFitType", SafeDbNull(style.SampleFitType));
                                    sqlquery.Parameters.AddWithValue("@StyleNo", SafeDbNull(style.StyleNo));
                                    sqlquery.Parameters.AddWithValue("@Quantity", SafeDbNull(style.Quantity));
                                    sqlquery.Parameters.AddWithValue("@Priority", SafeDbNull(style.Priority));
                                    sqlquery.Parameters.AddWithValue("@CurrentStage", SafeDbNull(style.CurrentStage));
                                    sqlquery.Parameters.AddWithValue("@StatusID", SafeDbNull(style.StatusID));
                                    sqlquery.Parameters.AddWithValue("@StatusUpdateDateTime", SafeDbNull(style.StatusUpdateDateTime));
                                    sqlquery.Parameters.AddWithValue("@TotalCountofOperations", SafeDbNull(style.TotalCountofOperations));
                                    sqlquery.Parameters.AddWithValue("@PlannedStartDateTime", SafeDbNull(style.PlannedStartDateTime));
                                    sqlquery.Parameters.AddWithValue("@ActualStartDateTime", SafeDbNull(style.ActualStartDateTime));
                                    sqlquery.Parameters.AddWithValue("@PlannedFinishDateTime", SafeDbNull(style.PlannedFinishDateTime));
                                    sqlquery.Parameters.AddWithValue("@ActualFinishDateTime", SafeDbNull(style.ActualFinishDateTime));

                                    int rows = sqlquery.ExecuteNonQuery();
                                    if (rows == 0)
                                        failedStyles.Add(style.SampleRequestNo);
                                }
                            }
                            catch (Exception ex2)
                            {
                                failedStyles.Add(style.SampleRequestNo);
                            }
                        }
                        catch (Exception ex3)
                        {
                            failedStyles.Add(style.SampleRequestNo);
                        }
                    }

                    transaction.Commit();
                }
            }

            if (failedStyles.Count > 0)
            {
                MessageBox.Show(
                    $"The following Sample Request Numbers could not be inserted or updated:\n\n{string.Join("\n", failedStyles)}",
                    "Import Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }

            return true;
        }

        public List<Style> GetAllStyleData()
        {
            using (var connection = realtimeConnection)
            {
                connection.Open();

                var styles = connection.Query<Style>("SELECT * FROM Styles ORDER BY SampleRequestNo;").ToList();

                return styles;
            }
        }

        public List<Style> GetAllStyleDataWithStatus()
        {
            using (var connection = realtimeConnection)
            {
                connection.Open();

                var styles = connection.Query<Style>("SELECT s.*, ss.Status, ss.FinalStatus, ot.OperatorID, ot.UpdatedAt AS StatusUpdateTrackingDateTime, op.OperatorEPFName, os.Status AS OperatorStatus FROM Styles s JOIN OperatorTracking ot ON ot.SRNumber=s.SampleRequestNo JOIN StyleStatuses ss ON ss.ID=ot.StatusID JOIN Operators op ON ot.OperatorID=op.ID JOIN OperatorStatuses os ON os.ID=op.StatusID ORDER BY SampleRequestNo;").ToList();

                return styles;
            }
        }

        public List<WipTracker> GetAllStylesGroupByOperator()
        {
            var styles = realtimeConnection.Query(@"SELECT op.ID, op.OperatorEPFName,
                Styles.SampleRequestNo,Styles.Customer, Styles.StyleNo, Styles.Quantity, Styles.Priority, Styles.CurrentStage,
                Styles.TotalCountofOperations, Styles.PlannedStartDateTime, Styles.PlannedFinishDateTime, Styles.ActualStartDateTime,Styles.ActualFinishDateTime,
                st.Status, st.FinalStatus FROM Styles
                JOIN OperatorTracking ot ON Styles.SampleRequestNo=ot.SRNumber
                JOIN Operators op ON ot.OperatorID=op.ID
                LEFT JOIN StyleStatuses st ON ot.StatusID = st.ID ORDER BY Styles.UpdatedAt DESC"
                );

            List<WipTracker> wipTrackers = new List<WipTracker>();

            var grouped = styles.GroupBy(item => new { item.ID, item.OperatorEPFName });

            foreach (var item in grouped)
            {
                WipTracker wipTracker = new WipTracker { ID = (int)item.Key.ID, OperatorEPFName = item.Key.OperatorEPFName };

                foreach (var style in item)
                {
                    var styleobj = new Style
                    {
                        SampleRequestNo = style.SampleRequestNo,
                        Customer = style.Customer,
                        StyleNo = style.StyleNo,
                        Quantity = (int)style.Quantity,
                        Priority = (int)style.Priority,
                        CurrentStage = style.CurrentStage,
                        TotalCountofOperations = (int)style.TotalCountofOperations,
                        PlannedStartDateTime = style.PlannedStartDateTime != null? Convert.ToDateTime(style.PlannedStartDateTime) : null,
                        PlannedFinishDateTime = style.PlannedFinishDateTime != null ? Convert.ToDateTime(style.PlannedFinishDateTime) : null,
                        ActualStartDateTime = style.ActualStartDateTime != null ? Convert.ToDateTime(style.ActualStartDateTime) : null,
                        ActualFinishDateTime = style.ActualFinishDateTime != null ? Convert.ToDateTime(style.ActualFinishDateTime) : null,
                        Status = style.Status,
                        FinalStatus = style.FinalStatus
                    };

                    wipTracker.Styles.Add(styleobj);
                }
                wipTrackers.Add( wipTracker );
            }
            return wipTrackers;
        }
        public bool UpdateStylePlannedTimeByStyleNo(string SRNo)
        {
            DateTime PlannedStartTime = DateTime.Now.AddMinutes(30);
            Debug.WriteLine(PlannedStartTime);
            int result = realtimeConnection.Execute ("UPDATE Styles SET PlannedStartDateTime=@PlannedStartTime, PlannedFinishDateTime=datetime(@PlannedStartTime, '+' || (strftime('%s', PlannedFinishDateTime) - strftime('%s', PlannedStartDateTime)) || ' seconds' ) WHERE SampleRequestNo=@SRNo", new { SRNo, PlannedStartTime });
            return result>0;
            
        }
    }
}
