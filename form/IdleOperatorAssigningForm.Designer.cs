namespace EyeonOps.form
{
    partial class IdleOperatorAssigningForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IdleOperatorAssigningForm));
            applyBtn = new Button();
            IdleOperatorDataGridView = new DataGridView();
            AssigningBtn = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)IdleOperatorDataGridView).BeginInit();
            SuspendLayout();
            // 
            // applyBtn
            // 
            applyBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            applyBtn.AutoSize = true;
            applyBtn.BackColor = Color.Black;
            applyBtn.FlatStyle = FlatStyle.Flat;
            applyBtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            applyBtn.ForeColor = Color.White;
            applyBtn.Location = new Point(713, 409);
            applyBtn.Name = "applyBtn";
            applyBtn.Size = new Size(75, 29);
            applyBtn.TabIndex = 3;
            applyBtn.Text = "Apply";
            applyBtn.UseVisualStyleBackColor = false;
            applyBtn.Click += applyBtn_Click;
            // 
            // IdleOperatorDataGridView
            // 
            IdleOperatorDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            IdleOperatorDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            IdleOperatorDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            IdleOperatorDataGridView.Columns.AddRange(new DataGridViewColumn[] { AssigningBtn });
            IdleOperatorDataGridView.EditMode = DataGridViewEditMode.EditOnEnter;
            IdleOperatorDataGridView.Location = new Point(12, 12);
            IdleOperatorDataGridView.Name = "IdleOperatorDataGridView";
            IdleOperatorDataGridView.Size = new Size(776, 393);
            IdleOperatorDataGridView.TabIndex = 4;
            IdleOperatorDataGridView.CellContentClick += IdleOperatorDataGridView_CellContentClick;
            // 
            // AssigningBtn
            // 
            AssigningBtn.Frozen = true;
            AssigningBtn.HeaderText = "Assign";
            AssigningBtn.Name = "AssigningBtn";
            AssigningBtn.Text = "Assigning";
            AssigningBtn.UseColumnTextForButtonValue = true;
            AssigningBtn.Width = 48;
            // 
            // IdleOperatorAssigningForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 64);
            ClientSize = new Size(800, 450);
            Controls.Add(IdleOperatorDataGridView);
            Controls.Add(applyBtn);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "IdleOperatorAssigningForm";
            Text = "Idle Operator Assigning";
            Load += IdleOperatorAssigningForm_Load;
            ((System.ComponentModel.ISupportInitialize)IdleOperatorDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button applyBtn;
        private DataGridView IdleOperatorDataGridView;
        private DataGridViewButtonColumn AssigningBtn;
    }
}