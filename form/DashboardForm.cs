using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EyeonOps.controls;
using EyeonOps.data;
using EyeonOps.models;
using ClosedXML.Excel;

namespace EyeonOps.form
{
    public partial class DashboardForm : Form
    {
        public void refreshalloperators()
        {
            List<Operator> operators = new OperatorAccess().GetAllOperatorData();
            foreach (Operator op in operators)
            {
                OperatorVisual operatorVisual = new OperatorVisual(op);
                OperatorsPanel.Controls.Add(operatorVisual);
            }
        }
        public DashboardForm()
        {
            InitializeComponent();
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            refreshalloperators();
            var summary = new OperatorAccess().GetOperatorCounts();

            totalOperatorlabel.Text = summary.Total.ToString();
            idlelOperatorabel.Text = summary.Idle.ToString();
            activeOperatorCountlabel.Text = summary.Active.ToString();
            waitingOperatorCountlabel.Text = summary.Waiting.ToString();
        }

        private void exportIdleOperatorsBtn_Click(object sender, EventArgs e)
        {
            try
            {
                List<Operator> idleOperators = new OperatorAccess().GetIdleOperatorsData();

                if (idleOperators == null || idleOperators.Count == 0)
                {
                    MessageBox.Show("No idle operators found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                    if (saveIdleOperatorsExcelFile.ShowDialog() == DialogResult.OK)
                    {
                        using (var workbook = new XLWorkbook())
                        {
                            var worksheet = workbook.Worksheets.Add("IdleOperators");

                            worksheet.Cell(1, 1).Value = "EPF Name";
                            worksheet.Cell(1, 2).Value = "Status";
                            worksheet.Cell(1, 3).Value = "Sample Room";
                            worksheet.Cell(1, 4).Value = "Grade";
                            worksheet.Cell(1, 5).Value = "Skill";
                            worksheet.Cell(1, 6).Value = "Idle Time";

                            int row = 2;
                            foreach (var op in idleOperators)
                            {
                                worksheet.Cell(row, 1).Value = op.OperatorEPFName;
                                worksheet.Cell(row, 2).Value = op.Status;
                                worksheet.Cell(row, 3).Value = op.SampleRoom;
                                worksheet.Cell(row, 4).Value = op.Grade;
                                worksheet.Cell(row, 5).Value = op.Sequence;
                                TimeSpan idleSpan = (TimeSpan)(DateTime.Now - op.StatusUpdateDateTime) - new TimeSpan(5, 30, 0);
                                worksheet.Cell(row, 6).Value = $"{(int)idleSpan.TotalHours:00}:{idleSpan.Minutes:00}";
                                row++;
                            }

                            worksheet.Columns().AdjustToContents();

                            workbook.SaveAs(saveIdleOperatorsExcelFile.FileName);

                            MessageBox.Show("Idle operators exported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error exporting idle operators: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
