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
    public partial class ImportTrackingForm : Form
    {
        private DataTable importedData;
        public ImportTrackingForm(DataTable Data)
        {
            InitializeComponent();
            importedData = Data;
            importedExcelFilePreview.DataSource = importedData;
        }

        private void applyBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var trackingList = new List<Tracking>();
                var missingOperators = new List<string>();

                foreach (DataRow row in importedData.Rows)
                {
                    string EPFName = row["OperatorEPFName"]?.ToString()?.Trim();

                    if (string.IsNullOrEmpty(EPFName))
                    {
                        missingOperators.Add("[Empty EPF Name]");
                        continue;
                    }
                    Operator getoperator = new OperatorAccess().getoperatorbyEPFName(EPFName);

                    if (getoperator == null)
                    {
                        missingOperators.Add(EPFName);
                        continue;
                    }

                    var tracking = new Tracking
                    {
                        OperatorID = getoperator.ID,
                        SRNumber = row["SRNumber"]?.ToString(),
                        SampleRequestNo = row["SampleRequestNo"]?.ToString(),
                        StyleStatus = row["StyleStatus"]?.ToString(),
                        StatusID = new StatusAccess().GetStyleStatusIDByStatusText(row["StyleStatus"].ToString() ?? "BOM PENDING"),
                        Sequence = row["Sequence"]?.ToString(),
                        CountofOperations = int.TryParse(row["CountofOperations"]?.ToString(), out int count) ? count : 0,
                        UpdatedAt= DateTime.Parse(row["StatusUpdateDateTime"]?.ToString()),
                    };
                    var holdStatuses = new List<string>
                    {
                        "SEWING OUT-HOLD",
                        "SEWING IN-HOLD",
                        "BONDING OUT-HOLD",
                        "BONDING IN-HOLD",
                        "H/O CK-HOLD"
                    };

                    if (holdStatuses.Contains(tracking.StyleStatus.ToUpper()))
                    {
                        new AlertAccess().InsertAlert("Waiting", $"{tracking.SRNumber} style is waiting.  Status of {tracking.StyleStatus}", "Style",1);
                    }

                    trackingList.Add(tracking);
                }
                bool result = new TrackingAccess().AddNewTrackingBulk(trackingList);
                Debug.WriteLine($"Insert Result: {result}");

                //foreach (var t in trackingList)
                //{
                //    //Debug.WriteLine(
                //    //    $"OperatorID: {t.OperatorID}, " +
                //    //    $"SRNumber: {t.SRNumber}, " +
                //    //    $"SampleRequestNo: {t.SampleRequestNo}, " +
                //    //    $"StyleStatus:{ t.StyleStatus},"+
                //    //    $"Sequence: {t.Sequence}, " +
                //    //    $"CountofOperations: {t.CountofOperations}"
                //    //);
                //}
                if (missingOperators.Any())
                {
                    string missingList = string.Join(", ", missingOperators.Distinct());
                    MessageBox.Show(
                        $"The following operators were not found in the database:\n\n{missingList}",
                        "Warning",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }

                MessageBox.Show("Operator tracking data imported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error while importing: {ex.Message}", "Import Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
