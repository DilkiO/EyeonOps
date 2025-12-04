using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EyeonOps.data;
using EyeonOps.models;

namespace EyeonOps.form
{
    public partial class IdleOperatorAssigningForm : Form
    {
        private string SampleRequestNo;
        private DateTime? PlannedStart;
        private DateTime? PlannedFinish;
        private Dictionary<int, string> SelectedOperators = new Dictionary<int, string>();

        public IdleOperatorAssigningForm(string sampleRequestNo, DateTime? plannedStart, DateTime? plannedFinish)
        {
            InitializeComponent();

            SampleRequestNo = sampleRequestNo;
            PlannedStart = plannedStart;
            PlannedFinish = plannedFinish;
        }

        private void applyBtn_Click(object sender, EventArgs e)
        {
            if (SelectedOperators.Keys.ToList().Count == 0)
            {
                MessageBox.Show("Please select at least one operator to assign.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool success = new AssignmentAccess().AddAssignments(SelectedOperators.Keys.ToList(), SampleRequestNo, PlannedStart, PlannedFinish);

            if (success)
            {
                bool isupdatedTracking = new TrackingAccess().UpdateTrackingByNewAssigned(SelectedOperators, SampleRequestNo);
                MessageBox.Show("Operators successfully assigned!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to assign operators.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void IdleOperatorAssigningForm_Load(object sender, EventArgs e)
        {
            List<Operator> idleoperators = new OperatorAccess().GetIdleOperatorsData();
            IdleOperatorDataGridView.DataSource = idleoperators;

            IdleOperatorDataGridView.CellFormatting += IdleOperatorDataGridView_CellFormatting;
        }

        private void IdleOperatorDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (IdleOperatorDataGridView.Columns[e.ColumnIndex].Name == "AssigningBtn")
            {
                Operator selectedOperator = (Operator)IdleOperatorDataGridView.Rows[e.RowIndex].DataBoundItem;


                if (SelectedOperators.ContainsKey(selectedOperator.ID))
                {
                    SelectedOperators.Remove(selectedOperator.ID);
                    IdleOperatorDataGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                }
                else
                {
                    SelectedOperators[selectedOperator.ID] = selectedOperator.Sequence;
                    IdleOperatorDataGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightBlue;
                }
            }
        }
        private void IdleOperatorDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (IdleOperatorDataGridView.Rows[e.RowIndex].DataBoundItem is Operator op)
            {
                Color rowColor = Color.White;

                switch (op.Grade)
                {
                    case "A":
                        rowColor = ColorTranslator.FromHtml("#26c965");
                        break;
                    case "B":
                        rowColor = ColorTranslator.FromHtml("#2698c9");
                        break;
                    case "C":
                        rowColor = ColorTranslator.FromHtml("#ddd815");
                        break;
                    case "D":
                        rowColor = ColorTranslator.FromHtml("#4a54ff");
                        break;
                }

                IdleOperatorDataGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = rowColor;
            }
        }
    }
}
