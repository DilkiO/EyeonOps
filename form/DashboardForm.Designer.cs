namespace EyeonOps.form
{
    partial class DashboardForm
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
            OperatorsPanel = new FlowLayoutPanel();
            exportIdleOperatorsBtn = new Button();
            saveIdleOperatorsExcelFile = new SaveFileDialog();
            totaloperatorCountPanel = new Panel();
            totalOperatorlabel = new Label();
            totalOperatorCountlabel = new Label();
            idleOperatorCountpanel = new Panel();
            idlelOperatorabel = new Label();
            idlelabel = new Label();
            activepanel = new Panel();
            activeOperatorCountlabel = new Label();
            activelabel = new Label();
            waitingpanel = new Panel();
            waitingOperatorCountlabel = new Label();
            waitinglabel = new Label();
            totaloperatorCountPanel.SuspendLayout();
            idleOperatorCountpanel.SuspendLayout();
            activepanel.SuspendLayout();
            waitingpanel.SuspendLayout();
            SuspendLayout();
            // 
            // OperatorsPanel
            // 
            OperatorsPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            OperatorsPanel.AutoScroll = true;
            OperatorsPanel.BackColor = Color.White;
            OperatorsPanel.Location = new Point(12, 91);
            OperatorsPanel.Name = "OperatorsPanel";
            OperatorsPanel.Size = new Size(776, 319);
            OperatorsPanel.TabIndex = 0;
            // 
            // exportIdleOperatorsBtn
            // 
            exportIdleOperatorsBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            exportIdleOperatorsBtn.AutoSize = true;
            exportIdleOperatorsBtn.BackColor = Color.Black;
            exportIdleOperatorsBtn.FlatStyle = FlatStyle.Flat;
            exportIdleOperatorsBtn.ForeColor = Color.White;
            exportIdleOperatorsBtn.Location = new Point(659, 416);
            exportIdleOperatorsBtn.Name = "exportIdleOperatorsBtn";
            exportIdleOperatorsBtn.Size = new Size(129, 27);
            exportIdleOperatorsBtn.TabIndex = 1;
            exportIdleOperatorsBtn.Text = "Export Idle Operators";
            exportIdleOperatorsBtn.UseVisualStyleBackColor = false;
            exportIdleOperatorsBtn.Click += exportIdleOperatorsBtn_Click;
            // 
            // saveIdleOperatorsExcelFile
            // 
            saveIdleOperatorsExcelFile.FileName = "IdleOperators.xlsx";
            saveIdleOperatorsExcelFile.Filter = "Excel Workbook|*.xlsx";
            saveIdleOperatorsExcelFile.Title = "Save Idle Operators Data";
            // 
            // totaloperatorCountPanel
            // 
            totaloperatorCountPanel.Anchor = AnchorStyles.Top;
            totaloperatorCountPanel.BackColor = Color.FromArgb(192, 255, 255);
            totaloperatorCountPanel.Controls.Add(totalOperatorlabel);
            totaloperatorCountPanel.Controls.Add(totalOperatorCountlabel);
            totaloperatorCountPanel.Location = new Point(38, 12);
            totaloperatorCountPanel.Name = "totaloperatorCountPanel";
            totaloperatorCountPanel.Size = new Size(167, 73);
            totaloperatorCountPanel.TabIndex = 2;
            // 
            // totalOperatorlabel
            // 
            totalOperatorlabel.BackColor = Color.Transparent;
            totalOperatorlabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            totalOperatorlabel.ForeColor = Color.Black;
            totalOperatorlabel.Location = new Point(-1, 31);
            totalOperatorlabel.Name = "totalOperatorlabel";
            totalOperatorlabel.Size = new Size(165, 34);
            totalOperatorlabel.TabIndex = 4;
            totalOperatorlabel.Text = "0";
            totalOperatorlabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // totalOperatorCountlabel
            // 
            totalOperatorCountlabel.BackColor = Color.Transparent;
            totalOperatorCountlabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            totalOperatorCountlabel.Location = new Point(-1, 10);
            totalOperatorCountlabel.Name = "totalOperatorCountlabel";
            totalOperatorCountlabel.Size = new Size(165, 21);
            totalOperatorCountlabel.TabIndex = 3;
            totalOperatorCountlabel.Text = "Total Operators";
            totalOperatorCountlabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // idleOperatorCountpanel
            // 
            idleOperatorCountpanel.Anchor = AnchorStyles.Top;
            idleOperatorCountpanel.BackColor = Color.FromArgb(255, 192, 192);
            idleOperatorCountpanel.Controls.Add(idlelOperatorabel);
            idleOperatorCountpanel.Controls.Add(idlelabel);
            idleOperatorCountpanel.Location = new Point(224, 12);
            idleOperatorCountpanel.Name = "idleOperatorCountpanel";
            idleOperatorCountpanel.Size = new Size(167, 73);
            idleOperatorCountpanel.TabIndex = 5;
            // 
            // idlelOperatorabel
            // 
            idlelOperatorabel.BackColor = Color.Transparent;
            idlelOperatorabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            idlelOperatorabel.ForeColor = Color.Black;
            idlelOperatorabel.Location = new Point(-1, 31);
            idlelOperatorabel.Name = "idlelOperatorabel";
            idlelOperatorabel.Size = new Size(165, 34);
            idlelOperatorabel.TabIndex = 4;
            idlelOperatorabel.Text = "0";
            idlelOperatorabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // idlelabel
            // 
            idlelabel.BackColor = Color.Transparent;
            idlelabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            idlelabel.Location = new Point(-1, 10);
            idlelabel.Name = "idlelabel";
            idlelabel.Size = new Size(165, 21);
            idlelabel.TabIndex = 3;
            idlelabel.Text = "Idle Operators";
            idlelabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // activepanel
            // 
            activepanel.Anchor = AnchorStyles.Top;
            activepanel.BackColor = Color.FromArgb(192, 255, 192);
            activepanel.Controls.Add(activeOperatorCountlabel);
            activepanel.Controls.Add(activelabel);
            activepanel.Location = new Point(410, 12);
            activepanel.Name = "activepanel";
            activepanel.Size = new Size(167, 73);
            activepanel.TabIndex = 6;
            // 
            // activeOperatorCountlabel
            // 
            activeOperatorCountlabel.BackColor = Color.Transparent;
            activeOperatorCountlabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            activeOperatorCountlabel.ForeColor = Color.Black;
            activeOperatorCountlabel.Location = new Point(-1, 31);
            activeOperatorCountlabel.Name = "activeOperatorCountlabel";
            activeOperatorCountlabel.Size = new Size(165, 34);
            activeOperatorCountlabel.TabIndex = 4;
            activeOperatorCountlabel.Text = "0";
            activeOperatorCountlabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // activelabel
            // 
            activelabel.BackColor = Color.Transparent;
            activelabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            activelabel.Location = new Point(-1, 10);
            activelabel.Name = "activelabel";
            activelabel.Size = new Size(165, 21);
            activelabel.TabIndex = 3;
            activelabel.Text = "Active Operators";
            activelabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // waitingpanel
            // 
            waitingpanel.Anchor = AnchorStyles.Top;
            waitingpanel.BackColor = Color.FromArgb(255, 255, 192);
            waitingpanel.Controls.Add(waitingOperatorCountlabel);
            waitingpanel.Controls.Add(waitinglabel);
            waitingpanel.Location = new Point(594, 12);
            waitingpanel.Name = "waitingpanel";
            waitingpanel.Size = new Size(167, 73);
            waitingpanel.TabIndex = 7;
            // 
            // waitingOperatorCountlabel
            // 
            waitingOperatorCountlabel.BackColor = Color.Transparent;
            waitingOperatorCountlabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            waitingOperatorCountlabel.ForeColor = Color.Black;
            waitingOperatorCountlabel.Location = new Point(-1, 31);
            waitingOperatorCountlabel.Name = "waitingOperatorCountlabel";
            waitingOperatorCountlabel.Size = new Size(165, 34);
            waitingOperatorCountlabel.TabIndex = 4;
            waitingOperatorCountlabel.Text = "0";
            waitingOperatorCountlabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // waitinglabel
            // 
            waitinglabel.BackColor = Color.Transparent;
            waitinglabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            waitinglabel.Location = new Point(-1, 10);
            waitinglabel.Name = "waitinglabel";
            waitinglabel.Size = new Size(165, 21);
            waitinglabel.TabIndex = 3;
            waitinglabel.Text = "Waiting Operators";
            waitinglabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 64);
            ClientSize = new Size(800, 450);
            Controls.Add(waitingpanel);
            Controls.Add(activepanel);
            Controls.Add(idleOperatorCountpanel);
            Controls.Add(totaloperatorCountPanel);
            Controls.Add(exportIdleOperatorsBtn);
            Controls.Add(OperatorsPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DashboardForm";
            Text = "DashboardForm";
            Load += DashboardForm_Load;
            totaloperatorCountPanel.ResumeLayout(false);
            idleOperatorCountpanel.ResumeLayout(false);
            activepanel.ResumeLayout(false);
            waitingpanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel OperatorsPanel;
        private Button exportIdleOperatorsBtn;
        private SaveFileDialog saveIdleOperatorsExcelFile;
        private Panel totaloperatorCountPanel;
        private Label totalOperatorCountlabel;
        private Label totalOperatorlabel;
        private Panel idleOperatorCountpanel;
        private Label idlelOperatorabel;
        private Label idlelabel;
        private Panel activepanel;
        private Label activeOperatorCountlabel;
        private Label activelabel;
        private Panel waitingpanel;
        private Label waitingOperatorCountlabel;
        private Label waitinglabel;
    }
}