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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EyeonOps.form
{
    public partial class ImportOperatorsForm : Form
    {
        private DataTable importedData;
        public ImportOperatorsForm(DataTable Data)
        {
            InitializeComponent();
            importedData = Data;
            //AutoMapColumns();
            importedExcelFilePreview.DataSource = importedData;
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
        }

        private void applyBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var operators = new List<Operator>();

                foreach (DataRow row in importedData.Rows)
                {
                    var op = new Operator
                    {
                        // Convert each field
                        OperatorEPFName = row["OperatorEPFName"]?.ToString() ?? string.Empty,
                        EPF = row["EPF"]?.ToString() ?? string.Empty,
                        Name = row["Name"]?.ToString() ?? string.Empty,
                        SampleRoom = row["SampleRoom"]?.ToString() ?? string.Empty,
                        Grade = row["Grade"]?.ToString() ?? string.Empty,
                        Sequence = row["Sequence"]?.ToString() ?? string.Empty,
                        JoinDate = DateTime.TryParse(row["JoinDate"]?.ToString(), out DateTime jd) ? jd : DateTime.Now,
                        StatusID = new StatusAccess().GetOperatorStatusIDByStatusText(row["Status"]?.ToString() ?? "Idle"),
                        StatusUpdateDateTime = DateTime.TryParse(row["StatusUpdateDateTime"]?.ToString(), out DateTime sud) ? sud : DateTime.Now
                    };

                    operators.Add(op);
                }

                bool result = new OperatorAccess().AddNewOperatorsBulk(operators);
                Debug.WriteLine($"Import result: {result}");

                //foreach (var op in operators)
                //{
                //    Debug.WriteLine(
                //        $"OperatorEPFName: {op.OperatorEPFName}, " +
                //        $"EPF: {op.EPF}, " +
                //        $"Name: {op.Name}, " +
                //        $"SampleRoom: {op.SampleRoom}, " +
                //        $"Grade: {op.Grade}, " +
                //        $"Sequence: {op.Sequence}, " +
                //        $"JoinDate: {op.JoinDate}, " +
                //        $"StatusID: {op.StatusID}, " 
                //    );
                //}

                MessageBox.Show("Operators imported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error while importing: {ex.Message}", "Import Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
