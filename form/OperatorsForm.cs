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
using ExcelDataReader;
using EyeonOps.data;
using EyeonOps.models;

namespace EyeonOps.form
{
    public partial class OperatorsForm : Form
    {
        private void OperatorsLoadDataSet()
        {
            try
            {
                //StatusColumn.DataSource = operatorStatuses;
                //StatusColumn.DisplayMember = "Status";
                //StatusColumn.ValueMember = "ID";
                //StatusColumn.DataPropertyName = "StatusID";

                List<Operator> operators = new OperatorAccess().GetAllOperatorData();

                operatorsDataSet.DataSource = null;
                operatorsDataSet.DataSource = operators;

                List<OperatorStatus> operatorStatuses = new StatusAccess().GetAllOperatorStatuses();
                DataGridViewComboBoxColumn StatusColumn = new DataGridViewComboBoxColumn
                {
                    Name = "StatusColumn",
                    HeaderText = "Status",
                    DataPropertyName = "StatusID",
                    DisplayMember = "Status",
                    ValueMember = "ID",
                    DataSource = operatorStatuses,
                    FlatStyle = FlatStyle.Flat,
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,
                    Frozen = true,
                };
                operatorsDataSet.Columns.Insert(2, StatusColumn);
                operatorsDataSet.AutoResizeColumns();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading operators: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public OperatorsForm()
        {
            InitializeComponent();
            OperatorsLoadDataSet();
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
        }

        private void importOperatorsBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (ImportOperatorsExcelFile)
                {
                    if (ImportOperatorsExcelFile.ShowDialog() == DialogResult.OK)
                    {
                        using (var stream = File.Open(ImportOperatorsExcelFile.FileName, FileMode.Open, FileAccess.Read))
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
                                ImportOperatorsForm importForm = new ImportOperatorsForm(result.Tables[0]);
                                importForm.ShowDialog();

                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Import Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            OperatorsLoadDataSet();
        }

        private void addOperatorBtn_Click(object sender, EventArgs e)
        {
            string name = inputOperatorName.Text.Trim();
            string epf = inputOperatorEpf.Text.Trim();
            string sampleRoom = dropdownSampleRoom.SelectedItem?.ToString();
            string grade = dropdownOperatorGrade.SelectedItem?.ToString();
            string sequence = dropdownSequence.SelectedItem?.ToString();
            DateTime joinDate = joinedDatePicker.Value;

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Please enter the operator's name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                inputOperatorName.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(epf))
            {
                MessageBox.Show("Please enter the operator's EPF number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                inputOperatorEpf.Focus();
                return;
            }

            if (!epf.All(char.IsDigit))
            {
                MessageBox.Show("EPF number must contain only digits.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                inputOperatorEpf.Focus();
                return;
            }

            if (dropdownSampleRoom.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a Sample Room.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dropdownSampleRoom.Focus();
                return;
            }

            if (dropdownOperatorGrade.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an Operator Grade.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dropdownOperatorGrade.Focus();
                return;
            }

            if (dropdownSequence.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a Sequence.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dropdownSequence.Focus();
                return;
            }

            if (joinDate.Date > DateTime.Now.Date)
            {
                MessageBox.Show("Join Date cannot be a future date.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                joinedDatePicker.Focus();
                return;
            }
            Operator newOperator = new Operator
            {
                Name = name,
                EPF = $"EPF{epf}",
                SampleRoom = sampleRoom,
                Grade = grade,
                Sequence = sequence,
                JoinDate = joinDate
            };

            bool success = new OperatorAccess().AddNewOperator(newOperator);

            if (success)
            {
                MessageBox.Show("Operator added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearBtn_Click(sender, EventArgs.Empty);
            }
            else
            {
                MessageBox.Show("Failed to add operator. Please try again.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            OperatorsLoadDataSet();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            inputOperatorName.Clear();
            inputOperatorEpf.Clear();
            dropdownSampleRoom.SelectedIndex = -1;
            dropdownOperatorGrade.SelectedIndex = -1;
            dropdownSequence.SelectedIndex = -1;
            joinedDatePicker.Value = DateTime.Now;
            if (currentedtiedoperatorID != null)
            {
                addOperatorBtn.Click -= editOperatorBtn_Click;
                addOperatorBtn.Click += addOperatorBtn_Click;
                currentedtiedoperatorID = null;
            }
            addOperatorBtn.Text = "Add Operator";
        }

        private void OperatorsForm_Load(object sender, EventArgs e)
        {
            joinedDatePicker.MaxDate = DateTime.Now.AddDays(1);
            List<OperatorStatus> operatorStatuses = new StatusAccess().GetAllOperatorStatuses();

        }
        private int? currentedtiedoperatorID = null;
        private void editOperatorBtn_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("Edit button clickered");
            if (currentedtiedoperatorID == null) return;

            string name = inputOperatorName.Text.Trim();
            string epf = inputOperatorEpf.Text.Trim();
            string sampleRoom = dropdownSampleRoom.SelectedItem?.ToString();
            string grade = dropdownOperatorGrade.SelectedItem?.ToString();
            string sequence = dropdownSequence.SelectedItem?.ToString();
            DateTime joinDate = joinedDatePicker.Value;

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Please enter the operator's name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                inputOperatorName.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(epf))
            {
                MessageBox.Show("Please enter the operator's EPF number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                inputOperatorEpf.Focus();
                return;
            }

            if (!epf.All(char.IsDigit))
            {
                MessageBox.Show("EPF number must contain only digits.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                inputOperatorEpf.Focus();
                return;
            }

            if (dropdownSampleRoom.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a Sample Room.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dropdownSampleRoom.Focus();
                return;
            }

            if (dropdownOperatorGrade.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an Operator Grade.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dropdownOperatorGrade.Focus();
                return;
            }

            if (dropdownSequence.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a Sequence.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dropdownSequence.Focus();
                return;
            }

            if (joinDate.Date > DateTime.Now.Date)
            {
                MessageBox.Show("Join Date cannot be a future date.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                joinedDatePicker.Focus();
                return;
            }
            Operator UpdateOperator = new Operator
            {
                ID = currentedtiedoperatorID ?? 0,
                Name = name,
                EPF = $"EPF{epf}",
                SampleRoom = sampleRoom,
                Grade = grade,
                Sequence = sequence,
                JoinDate = joinDate
            };

            bool success = new OperatorAccess().UpdateOperator(UpdateOperator);

            if (success)
            {
                MessageBox.Show("Operator edited successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed to edit operator. Please try again.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            OperatorsLoadDataSet();
            clearBtn_Click(sender, EventArgs.Empty);
        }

        private void operatorsDataSet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (operatorsDataSet.Columns[e.ColumnIndex].Name == "editColumn")
            {
                Operator selectedOperator = (Operator)operatorsDataSet.Rows[e.RowIndex].DataBoundItem;
                inputOperatorName.Text = selectedOperator.Name;
                inputOperatorEpf.Text = selectedOperator.EPF.Substring(3);
                dropdownSampleRoom.SelectedItem = selectedOperator.SampleRoom;
                dropdownOperatorGrade.SelectedItem = selectedOperator.Grade;
                dropdownSequence.SelectedItem = selectedOperator.Sequence;
                joinedDatePicker.Value = selectedOperator.JoinDate;

                if (currentedtiedoperatorID == null)
                {
                    addOperatorBtn.Click -= addOperatorBtn_Click;
                    addOperatorBtn.Click += editOperatorBtn_Click;
                    addOperatorBtn.Text = "Edit Operator";
                }

                currentedtiedoperatorID = selectedOperator.ID;
            }
            else if (operatorsDataSet.Columns[e.ColumnIndex].Name == "deleteColumn")
            {
                currentedtiedoperatorID = null;
                Operator selectedOperator = (Operator)operatorsDataSet.Rows[e.RowIndex].DataBoundItem;
                var confirm = MessageBox.Show($"Are you sure you want to delete operator '{selectedOperator.Name}'?",
                                              "Confirm Delete",
                                              MessageBoxButtons.YesNo,
                                              MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    bool deleted = new OperatorAccess().DeleteOperator(selectedOperator.ID);
                    if (deleted)
                    {
                        MessageBox.Show("Operator deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        OperatorsLoadDataSet();
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete operator.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void operatorsDataSet_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
                if (operatorsDataSet.Columns[e.ColumnIndex].Name == "StatusColumn" && e.RowIndex >= 0)
                {
                    Operator Op = (Operator)operatorsDataSet.Rows[e.RowIndex].DataBoundItem;

                    int newStatusId = Convert.ToInt32(operatorsDataSet.Rows[e.RowIndex].Cells["StatusColumn"].Value);

                    new OperatorAccess().UpdateOperatorStatus(Op.ID, newStatusId);

                OperatorsLoadDataSet();
            }
        }
    }
}
