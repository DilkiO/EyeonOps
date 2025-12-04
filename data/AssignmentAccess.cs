using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using DocumentFormat.OpenXml.Office2010.Excel;
using DocumentFormat.OpenXml.Wordprocessing;
using EyeonOps.database;
using EyeonOps.models;
using Microsoft.Data.Sqlite;

namespace EyeonOps.data
{
    internal class AssignmentAccess
    {
        private SqliteConnection realtimeConnection;
        public AssignmentAccess()
        {
            realtimeConnection = Database.InitializeRealtime();
        }
        public bool AddAssignments(List<int> operatorIds, string sampleRequestNo, DateTime? plannedStart, DateTime? plannedFinish)
        {
            if (operatorIds == null || operatorIds.Count == 0)
                return false;
            bool finalresult=true;
            foreach (int operatorId in operatorIds) 
            {
                string query= @"
                        INSERT INTO Assignments (OperatorID, SampleRequestNo, PlannedStartDate, PlannedFinishDate)
                        VALUES (@OperatorID, @SampleRequestNo, @PlannedStartDate, @PlannedFinishDate);";
                int result = realtimeConnection.Execute(query, new
                        {
                            OperatorID = operatorId,
                            SampleRequestNo = sampleRequestNo,
                            PlannedStartDate = plannedStart,
                            PlannedFinishDate = plannedFinish
                        });
                bool statusUpdated=new OperatorAccess().UpdateOperatorStatusByStatusName(operatorId, "Active");
                Debug.WriteLine("Status Updated" + statusUpdated);
                if (result == 0) 
                { 
                    finalresult=false;
                    break;
                }
            }
            return finalresult;
        }
    }
}
