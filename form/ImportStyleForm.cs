using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EyeonOps.data;
using EyeonOps.models;

namespace EyeonOps.form
{
    public partial class ImportStyleForm : Form
    {
        private DataTable importedData;
        public ImportStyleForm(DataTable Data)
        {
            InitializeComponent();
            importedData = Data;
            //AutoMapColumns();
            importedExcelFilePreview.DataSource = importedData;
        }
        private void AutoMapColumns()
        {
            // TODO: Want to set up default matching words and mannualy change those words as required.
            foreach (DataColumn col in importedData.Columns)
            {
                string normalized = col.ColumnName.Trim().ToLower();
                if (normalized.Contains("column0")) col.ColumnName = "SampleRequestNo";
                else if (normalized.Contains("column1")) col.ColumnName = "Customer";
                else if (normalized.Contains("column2")) col.ColumnName = "SampleFitType";
                else if (normalized.Contains("column3")) col.ColumnName = "StyleNo";
                else if (normalized.Contains("column4")) col.ColumnName = "Quantity";
                else if (normalized.Contains("column5")) col.ColumnName = "Priority";
                else if (normalized.Contains("column6")) col.ColumnName = "CurrentStage";
                else if (normalized.Contains("column7")) col.ColumnName = "StatusUpdateDateTime";
                else if (normalized.Contains("column8")) col.ColumnName = "TotalCountofOperations";
                else if (normalized.Contains("column9")) col.ColumnName = "PlannedStartDateTime";
                else if (normalized.Contains("column10")) col.ColumnName = "ActualStartDateTime";
                else if (normalized.Contains("column11")) col.ColumnName = "PlannedFinishDateTime";
                else if (normalized.Contains("column12")) col.ColumnName = "ActualFinishDateTime";
            }
        }

        private void applyBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var styles = new List<Style>();

                foreach (DataRow row in importedData.Rows)
                {
                    var style = new Style
                    {
                        SampleRequestNo = row["SampleRequestNo"].ToString(),
                        Customer = row["Customer"].ToString(),
                        SampleFitType = row["SampleFitType"].ToString(),
                        StyleNo = row["StyleNo"].ToString(),
                        Quantity = int.TryParse(row["Quantity"].ToString(), out int qty) ? qty : 0,
                        Priority = int.TryParse(row["Priority"].ToString(), out int pr) ? pr : 0,
                        CurrentStage = row["CurrentStage"].ToString(),
                        StatusID = new StatusAccess().GetStyleStatusIDByStatusText(row["CurrentStage"].ToString() ?? "BOM PENDING"),
                        TotalCountofOperations = 0,
                        StatusUpdateDateTime= row["StatusUpdateDateTime"]==null|| row["StatusUpdateDateTime"]== DBNull.Value?null: DateTime.TryParse(row["StatusUpdateDateTime"].ToString(), out DateTime sudt)?sudt: (DateTime?)null,
                        PlannedStartDateTime = DateTime.Parse(row["PlannedStartDateTime"].ToString()),
                        ActualStartDateTime = row["ActualStartDateTime"] == null || row["ActualStartDateTime"] == DBNull.Value ? null : DateTime.TryParse(row["ActualStartDateTime"].ToString(), out DateTime asdt) ? asdt : (DateTime?)null,
                        PlannedFinishDateTime = DateTime.Parse(row["PlannedFinishDateTime"].ToString()),
                        ActualFinishDateTime = row["ActualFinishDateTime"] == null || row["ActualFinishDateTime"] == DBNull.Value ? null : DateTime.TryParse(row["ActualFinishDateTime"].ToString(), out DateTime afdt) ? afdt : (DateTime?)null,
                    };
                    var holdStatuses = new List<string>
                    {
                        "SEWING OUT-HOLD",
                        "SEWING IN-HOLD",
                        "BONDING OUT-HOLD",
                        "BONDING IN-HOLD",
                        "H/O CK-HOLD"
                    };

                    if (holdStatuses.Contains(style.CurrentStage.ToUpper()) && style.PlannedStartDateTime.Date == DateTime.Today)
                    {
                        new AlertAccess().InsertAlert("Waiting", $"{style.SampleRequestNo} style is waiting. Status of {style.Status}", "Style", 1);
                    }
                    styles.Add(style);
                }

                bool result=new StyleAccess().AddNewStylesBulk(styles);
                Debug.WriteLine(result);
        //        foreach (var style in styles)
        //        {
        //            Debug.WriteLine(
        //    $"SampleRequestNo: {style.SampleRequestNo}, " +
        //    $"Customer: {style.Customer}, " +
        //    $"SampleFitType: {style.SampleFitType}, " +
        //    $"StyleNo: {style.StyleNo}, " +
        //    $"Quantity: {style.Quantity}, " +
        //    $"Priority: {style.Priority}, " +
        //    $"CurrentStage: {style.CurrentStage}, " +
        //    $"StatusID: {style.StatusID}, " +
        //    $"TotalCountofOperations: {style.TotalCountofOperations}, " +
        //    $"StatusUpdateDateTime: {style.StatusUpdateDateTime}, " +
        //    $"ActualStartDateTime: {style.ActualStartDateTime}, " +
        //    $"PlannedFinishDateTime: {style.PlannedFinishDateTime}, " +
        //    $"ActualFinishDateTime: {style.ActualFinishDateTime}"
        //);
        //        }
                MessageBox.Show("Styles imported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error while importing: {ex.Message}", "Import Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
