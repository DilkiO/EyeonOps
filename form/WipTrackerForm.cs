using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Office2021.DocumentTasks;
using ExcelDataReader;
using EyeonOps.controls;
using EyeonOps.data;
using EyeonOps.models;


namespace EyeonOps.form
{
    public partial class WipTrackerForm : Form
    {
        private List<WipTracker> wipTrackers;
        private WIPTrackerChart WIPchart;
   
        public WipTrackerForm()
        {
            InitializeComponent();
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
        }
        private void RefreshWIPVisual(object sender, FormClosedEventArgs e)
        {
            WipTrackerForm_Load(sender, e);
        }
        private void importStylesBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (ImportStylesExcelFile)
                {
                    if (ImportStylesExcelFile.ShowDialog() == DialogResult.OK)
                    {
                        using (var stream = File.Open(ImportStylesExcelFile.FileName, FileMode.Open, FileAccess.Read))
                        {
                            using (var reader = ExcelReaderFactory.CreateReader(stream))
                            {
                                var conf = new ExcelDataSetConfiguration
                                {
                                    ConfigureDataTable = _ => new ExcelDataTableConfiguration
                                    {
                                        UseHeaderRow = true
                                    }
                                };
                                var result = reader.AsDataSet(conf);
                                ImportStyleForm importForm = new ImportStyleForm(result.Tables[0]);
                                importForm.FormClosed += RefreshWIPVisual;
                                importForm.Show();

                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Import Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //StyleLoadDataSet();
        }

        private void updateTrackingBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (UpdateTrackingExcelFile)
                {
                    if (UpdateTrackingExcelFile.ShowDialog() == DialogResult.OK)
                    {
                        using (var stream = File.Open(UpdateTrackingExcelFile.FileName, FileMode.Open, FileAccess.Read))
                        {
                            using (var reader = ExcelReaderFactory.CreateReader(stream))
                            {
                                var conf = new ExcelDataSetConfiguration
                                {
                                    ConfigureDataTable = _ => new ExcelDataTableConfiguration
                                    {
                                        UseHeaderRow = true
                                    }
                                };
                                var result = reader.AsDataSet(conf);
                                ImportTrackingForm importForm = new ImportTrackingForm(result.Tables[0]);
                                importForm.FormClosed += RefreshWIPVisual;
                                importForm.Show();

                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Import Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadStyleDataSetForWIPTracker()
        {
            wipTrackers = new StyleAccess().GetAllStylesGroupByOperator();
        }

        private void WipTrackerForm_Load(object sender, EventArgs e)
        {
            if (WIPchart != null) WIPchart.Dispose2(true);

            WIPchart = new WIPTrackerChart();
            WIPchart.Dock = DockStyle.Fill;

            LoadStyleDataSetForWIPTracker();

            foreach (var itemRow in wipTrackers)
            {
                Row row = new Row { Label = itemRow.OperatorEPFName };

                foreach (Style style in itemRow.Styles)
                {
                    row.StyleTimeBlocks.Add(new StyleTimeBlock
                    {
                        Label = style.SampleRequestNo,
                        PlannedStartTime = style.PlannedStartDateTime,
                        PlannedEndTime = style.PlannedFinishDateTime,
                        Color = style.FinalStatus=="PENDING" || style.FinalStatus== "IN PROCESS"? Color.Red:Color.Green,
                    });
                }
                WIPchart.Rows.Add(row);
            }

            WIPchart.VisualChart();

            wipTrackerChartPanel.Controls.Clear();
            wipTrackerChartPanel.Controls.Add(WIPchart);
        }
    }
}
