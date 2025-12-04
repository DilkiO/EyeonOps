namespace EyeonOps.form
{
    partial class OperatorsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            importOperatorsBtn = new Button();
            ImportOperatorsExcelFile = new OpenFileDialog();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            operatorsDataSet = new DataGridView();
            deleteColumn = new DataGridViewButtonColumn();
            editColumn = new DataGridViewButtonColumn();
            nameLable = new Label();
            inputOperatorName = new TextBox();
            inputOperatorEpf = new TextBox();
            epfLabel = new Label();
            sampleRoomlabel = new Label();
            joinedDateLabel = new Label();
            SkillLabel = new Label();
            gradeLable = new Label();
            dropdownSequence = new ComboBox();
            dropdownOperatorGrade = new ComboBox();
            joinedDatePicker = new DateTimePicker();
            clearBtn = new Button();
            addOperatorBtn = new Button();
            dropdownSampleRoom = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)operatorsDataSet).BeginInit();
            SuspendLayout();
            // 
            // importOperatorsBtn
            // 
            importOperatorsBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            importOperatorsBtn.AutoSize = true;
            importOperatorsBtn.BackColor = Color.Black;
            importOperatorsBtn.FlatStyle = FlatStyle.Flat;
            importOperatorsBtn.ForeColor = Color.White;
            importOperatorsBtn.Location = new Point(678, 12);
            importOperatorsBtn.Name = "importOperatorsBtn";
            importOperatorsBtn.Size = new Size(110, 27);
            importOperatorsBtn.TabIndex = 1;
            importOperatorsBtn.Text = "Import Operators";
            importOperatorsBtn.UseVisualStyleBackColor = false;
            importOperatorsBtn.Click += importOperatorsBtn_Click;
            // 
            // operatorsDataSet
            // 
            operatorsDataSet.AllowUserToAddRows = false;
            operatorsDataSet.AllowUserToDeleteRows = false;
            operatorsDataSet.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            operatorsDataSet.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            operatorsDataSet.BackgroundColor = Color.FromArgb(0, 0, 64);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            operatorsDataSet.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            operatorsDataSet.ColumnHeadersHeight = 25;
            operatorsDataSet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            operatorsDataSet.Columns.AddRange(new DataGridViewColumn[] { deleteColumn, editColumn });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            operatorsDataSet.DefaultCellStyle = dataGridViewCellStyle4;
            operatorsDataSet.EditMode = DataGridViewEditMode.EditOnEnter;
            operatorsDataSet.Location = new Point(12, 119);
            operatorsDataSet.Name = "operatorsDataSet";
            operatorsDataSet.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            operatorsDataSet.Size = new Size(776, 317);
            operatorsDataSet.TabIndex = 3;
            operatorsDataSet.CellContentClick += operatorsDataSet_CellContentClick;
            operatorsDataSet.CellValueChanged += operatorsDataSet_CellValueChanged;
            // 
            // deleteColumn
            // 
            deleteColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.Black;
            dataGridViewCellStyle2.ForeColor = Color.White;
            deleteColumn.DefaultCellStyle = dataGridViewCellStyle2;
            deleteColumn.Frozen = true;
            deleteColumn.HeaderText = "Delete";
            deleteColumn.Name = "deleteColumn";
            deleteColumn.Text = "🗑️";
            deleteColumn.UseColumnTextForButtonValue = true;
            deleteColumn.Width = 46;
            // 
            // editColumn
            // 
            editColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.ForeColor = Color.White;
            editColumn.DefaultCellStyle = dataGridViewCellStyle3;
            editColumn.Frozen = true;
            editColumn.HeaderText = "Edit";
            editColumn.Name = "editColumn";
            editColumn.Resizable = DataGridViewTriState.True;
            editColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            editColumn.Text = "✏️";
            editColumn.UseColumnTextForButtonValue = true;
            editColumn.Width = 52;
            // 
            // nameLable
            // 
            nameLable.AutoSize = true;
            nameLable.Font = new Font("Segoe UI", 9.75F);
            nameLable.Location = new Point(12, 9);
            nameLable.Name = "nameLable";
            nameLable.Size = new Size(43, 17);
            nameLable.TabIndex = 4;
            nameLable.Text = "Name";
            // 
            // inputOperatorName
            // 
            inputOperatorName.Location = new Point(12, 29);
            inputOperatorName.Name = "inputOperatorName";
            inputOperatorName.Size = new Size(180, 23);
            inputOperatorName.TabIndex = 5;
            // 
            // inputOperatorEpf
            // 
            inputOperatorEpf.Location = new Point(232, 29);
            inputOperatorEpf.Name = "inputOperatorEpf";
            inputOperatorEpf.Size = new Size(180, 23);
            inputOperatorEpf.TabIndex = 7;
            // 
            // epfLabel
            // 
            epfLabel.AutoSize = true;
            epfLabel.Font = new Font("Segoe UI", 9.75F);
            epfLabel.Location = new Point(232, 9);
            epfLabel.Name = "epfLabel";
            epfLabel.Size = new Size(28, 17);
            epfLabel.TabIndex = 6;
            epfLabel.Text = "EPF";
            // 
            // sampleRoomlabel
            // 
            sampleRoomlabel.AutoSize = true;
            sampleRoomlabel.Font = new Font("Segoe UI", 9.75F);
            sampleRoomlabel.Location = new Point(444, 9);
            sampleRoomlabel.Name = "sampleRoomlabel";
            sampleRoomlabel.Size = new Size(90, 17);
            sampleRoomlabel.TabIndex = 8;
            sampleRoomlabel.Text = "Sample Room";
            // 
            // joinedDateLabel
            // 
            joinedDateLabel.AutoSize = true;
            joinedDateLabel.Font = new Font("Segoe UI", 9.75F);
            joinedDateLabel.Location = new Point(444, 60);
            joinedDateLabel.Name = "joinedDateLabel";
            joinedDateLabel.Size = new Size(77, 17);
            joinedDateLabel.TabIndex = 14;
            joinedDateLabel.Text = "Joined Data";
            // 
            // SkillLabel
            // 
            SkillLabel.AutoSize = true;
            SkillLabel.Font = new Font("Segoe UI", 9.75F);
            SkillLabel.Location = new Point(232, 60);
            SkillLabel.Name = "SkillLabel";
            SkillLabel.Size = new Size(30, 17);
            SkillLabel.TabIndex = 12;
            SkillLabel.Text = "Skill";
            // 
            // gradeLable
            // 
            gradeLable.AutoSize = true;
            gradeLable.Font = new Font("Segoe UI", 9.75F);
            gradeLable.Location = new Point(12, 60);
            gradeLable.Name = "gradeLable";
            gradeLable.Size = new Size(44, 17);
            gradeLable.TabIndex = 10;
            gradeLable.Text = "Grade";
            // 
            // dropdownSequence
            // 
            dropdownSequence.FormattingEnabled = true;
            dropdownSequence.Items.AddRange(new object[] { "S", "B" });
            dropdownSequence.Location = new Point(232, 80);
            dropdownSequence.Name = "dropdownSequence";
            dropdownSequence.Size = new Size(180, 23);
            dropdownSequence.TabIndex = 16;
            // 
            // dropdownOperatorGrade
            // 
            dropdownOperatorGrade.FormattingEnabled = true;
            dropdownOperatorGrade.Items.AddRange(new object[] { "A", "B", "C", "D" });
            dropdownOperatorGrade.Location = new Point(12, 80);
            dropdownOperatorGrade.Name = "dropdownOperatorGrade";
            dropdownOperatorGrade.Size = new Size(180, 23);
            dropdownOperatorGrade.TabIndex = 17;
            // 
            // joinedDatePicker
            // 
            joinedDatePicker.CustomFormat = "[ddd]  dd-MMM-yyyy";
            joinedDatePicker.Format = DateTimePickerFormat.Custom;
            joinedDatePicker.Location = new Point(444, 80);
            joinedDatePicker.MaxDate = new DateTime(2025, 10, 22, 0, 0, 0, 0);
            joinedDatePicker.Name = "joinedDatePicker";
            joinedDatePicker.Size = new Size(180, 23);
            joinedDatePicker.TabIndex = 18;
            joinedDatePicker.Value = new DateTime(2025, 10, 22, 0, 0, 0, 0);
            // 
            // clearBtn
            // 
            clearBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            clearBtn.BackColor = Color.DarkRed;
            clearBtn.FlatStyle = FlatStyle.Flat;
            clearBtn.ForeColor = Color.White;
            clearBtn.Location = new Point(680, 82);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(108, 23);
            clearBtn.TabIndex = 19;
            clearBtn.Text = "❌ Clear";
            clearBtn.UseVisualStyleBackColor = false;
            clearBtn.Click += clearBtn_Click;
            // 
            // addOperatorBtn
            // 
            addOperatorBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            addOperatorBtn.BackColor = Color.MidnightBlue;
            addOperatorBtn.FlatStyle = FlatStyle.Flat;
            addOperatorBtn.ForeColor = Color.White;
            addOperatorBtn.Location = new Point(680, 53);
            addOperatorBtn.Name = "addOperatorBtn";
            addOperatorBtn.Size = new Size(108, 23);
            addOperatorBtn.TabIndex = 20;
            addOperatorBtn.Text = "➕ Add Operator";
            addOperatorBtn.UseVisualStyleBackColor = false;
            addOperatorBtn.Click += addOperatorBtn_Click;
            // 
            // dropdownSampleRoom
            // 
            dropdownSampleRoom.FormattingEnabled = true;
            dropdownSampleRoom.Items.AddRange(new object[] { "Sportswear", "Workwear", "Outerwear" });
            dropdownSampleRoom.Location = new Point(444, 29);
            dropdownSampleRoom.Name = "dropdownSampleRoom";
            dropdownSampleRoom.Size = new Size(180, 23);
            dropdownSampleRoom.TabIndex = 21;
            // 
            // OperatorsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 64);
            ClientSize = new Size(800, 450);
            Controls.Add(dropdownSampleRoom);
            Controls.Add(addOperatorBtn);
            Controls.Add(clearBtn);
            Controls.Add(joinedDatePicker);
            Controls.Add(dropdownOperatorGrade);
            Controls.Add(dropdownSequence);
            Controls.Add(joinedDateLabel);
            Controls.Add(SkillLabel);
            Controls.Add(gradeLable);
            Controls.Add(sampleRoomlabel);
            Controls.Add(inputOperatorEpf);
            Controls.Add(epfLabel);
            Controls.Add(inputOperatorName);
            Controls.Add(nameLable);
            Controls.Add(operatorsDataSet);
            Controls.Add(importOperatorsBtn);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "OperatorsForm";
            Text = "OperatorsForm";
            Load += OperatorsForm_Load;
            ((System.ComponentModel.ISupportInitialize)operatorsDataSet).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button importOperatorsBtn;
        private OpenFileDialog ImportOperatorsExcelFile;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DataGridView operatorsDataSet;
        private Label nameLable;
        private TextBox inputOperatorName;
        private TextBox inputOperatorEpf;
        private Label epfLabel;
        private Label sampleRoomlabel;
        private Label joinedDateLabel;
        private Label SkillLabel;
        private Label gradeLable;
        private ComboBox dropdownSequence;
        private ComboBox dropdownOperatorGrade;
        private DateTimePicker joinedDatePicker;
        private Button clearBtn;
        private Button addOperatorBtn;
        private ComboBox dropdownSampleRoom;
        private DataGridViewButtonColumn deleteColumn;
        private DataGridViewButtonColumn editColumn;
    }
}