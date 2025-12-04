using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using DocumentFormat.OpenXml.Drawing.Charts;
using DocumentFormat.OpenXml.EMMA;
using EyeonOps.database;
using EyeonOps.models;
using Microsoft.Data.Sqlite;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EyeonOps.data
{
    internal class TrackingAccess
    {
        private SqliteConnection realtimeConnection;
        public List<int> GetStyleAssignedOperatorIds(string SampleRequestNo)
        {
            return realtimeConnection.Query<int>("SELECT OperatorID FROM OperatorTracking WHERE SampleRequestNo = @SampleRequestNo",new { SampleRequestNo }).ToList();
        }
        public TrackingAccess()
        {
            realtimeConnection = Database.InitializeRealtime();
        }
        public bool AddNewTrackingBulk(List<Tracking> trackingList)
        {
            if (trackingList == null || trackingList.Count == 0)
                return false;

            realtimeConnection.Execute("DELETE FROM OperatorTracking");

            using (var connection = realtimeConnection)
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    string query = @"
                        INSERT INTO OperatorTracking
                        (OperatorID, SRNumber, SampleRequestNo, StyleStatus, StatusID, Sequence, CountofOperations, UpdatedAt)
                        VALUES (@OperatorID, @SRNumber, @SampleRequestNo, @StyleStatus, @StatusID, @Sequence, @CountofOperations, @UpdatedAt);";

                    connection.Execute(query, trackingList, transaction);

                    transaction.Commit();
                    return true;
                }
            }
        }
        public bool UpdateTrackingByNewAssigned(Dictionary<int, string> operatorsList, string SampleRequestNo)
        {
            if (operatorsList == null || operatorsList.Count == 0)
                return false;

            StatusAccess statusAccess = new StatusAccess();

            bool finalresult = true;
            foreach (var operatorskill in operatorsList)
            {
                int StatusID = operatorskill.Value == "B" ? statusAccess.GetStyleStatusIDByStatusText("BONDING IN") : statusAccess.GetStyleStatusIDByStatusText("SEWING IN");
                string StyleStatus = operatorskill.Value == "B" ? "BONDING IN" : "SEWING IN";

                bool isUpdatedPlannedtime = new StyleAccess().UpdateStylePlannedTimeByStyleNo(SampleRequestNo);
                if (!isUpdatedPlannedtime)
                {
                    finalresult = false;
                    break;
                }

                realtimeConnection.Execute("DELETE FROM OperatorTracking WHERE OperatorID=@OperatorID", new
                {
                    OperatorID = operatorskill.Key
                });

                string query = @"
                        INSERT INTO OperatorTracking
                        (OperatorID, SRNumber, SampleRequestNo, StyleStatus, StatusID, Sequence, CountofOperations)
                        VALUES (@OperatorID, @SRNumber, @SampleRequestNo, @StyleStatus, @StatusID, @Sequence, @CountofOperations);";
                int result = realtimeConnection.Execute(query, new
                {
                    OperatorID = operatorskill.Key,
                    SRNumber = SampleRequestNo,
                    SampleRequestNo = SampleRequestNo,
                    StyleStatus = StyleStatus,
                    StatusID = StatusID,
                    Sequence = operatorskill.Value,
                    CountofOperations = 0

                });

                if (result == 0)
                {
                    finalresult = false;
                    break;
                }

                bool styleStatusUpdated = new StyleAccess().updateStyleStatusBySrNumber(SampleRequestNo, StatusID);
                if (styleStatusUpdated)
                {
                    finalresult = false;
                    break;
                }
                Debug.WriteLine("Style Status updated");
                int operatorStatusID = new StatusAccess().GetOperatorStatusIDByStatusText("Active");
                bool operatorStatusUpdated = new OperatorAccess().UpdateOperatorStatus(operatorskill.Key, operatorStatusID);
                if (operatorStatusUpdated)
                {
                    finalresult = false;
                    break;
                }
                Debug.WriteLine("operator Status updated");
            }
            return finalresult;
        }
    }
}
