namespace EyeonOps.form
{
    partial class WipTrackerForm
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
            importStylesBtn = new Button();
            ImportStylesExcelFile = new OpenFileDialog();
            updateTrackingBtn = new Button();
            UpdateTrackingExcelFile = new OpenFileDialog();
            wipTrackerChartPanel = new Panel();
            SuspendLayout();
            // 
            // importStylesBtn
            // 
            importStylesBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            importStylesBtn.AutoSize = true;
            importStylesBtn.BackColor = Color.Black;
            importStylesBtn.FlatStyle = FlatStyle.Flat;
            importStylesBtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            importStylesBtn.ForeColor = Color.White;
            importStylesBtn.Location = new Point(692, 12);
            importStylesBtn.Name = "importStylesBtn";
            importStylesBtn.Size = new Size(96, 29);
            importStylesBtn.TabIndex = 1;
            importStylesBtn.Text = "Import Styles";
            importStylesBtn.UseVisualStyleBackColor = false;
            importStylesBtn.Click += importStylesBtn_Click;
            // 
            // ImportStylesExcelFile
            // 
            ImportStylesExcelFile.Filter = "Excel Files|*.xls;*.xlsx";
            ImportStylesExcelFile.Title = "Select Styles Excel File";
            // 
            // updateTrackingBtn
            // 
            updateTrackingBtn.AutoSize = true;
            updateTrackingBtn.BackColor = Color.Black;
            updateTrackingBtn.FlatStyle = FlatStyle.Flat;
            updateTrackingBtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            updateTrackingBtn.ForeColor = Color.White;
            updateTrackingBtn.Location = new Point(12, 12);
            updateTrackingBtn.Name = "updateTrackingBtn";
            updateTrackingBtn.Size = new Size(115, 29);
            updateTrackingBtn.TabIndex = 3;
            updateTrackingBtn.Text = "Update Tracking";
            updateTrackingBtn.UseVisualStyleBackColor = false;
            updateTrackingBtn.Click += updateTrackingBtn_Click;
            // 
            // UpdateTrackingExcelFile
            // 
            UpdateTrackingExcelFile.Title = "Upload Tracking Data";
            // 
            // wipTrackerChartPanel
            // 
            wipTrackerChartPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            wipTrackerChartPanel.BackColor = Color.White;
            wipTrackerChartPanel.Location = new Point(12, 45);
            wipTrackerChartPanel.Name = "wipTrackerChartPanel";
            wipTrackerChartPanel.Size = new Size(776, 393);
            wipTrackerChartPanel.TabIndex = 4;
            // 
            // WipTrackerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 64);
            ClientSize = new Size(800, 450);
            Controls.Add(wipTrackerChartPanel);
            Controls.Add(updateTrackingBtn);
            Controls.Add(importStylesBtn);
            FormBorderStyle = FormBorderStyle.None;
            Name = "WipTrackerForm";
            Text = "WipTrackerForm";
            Load += WipTrackerForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button importStylesBtn;
        private OpenFileDialog ImportStylesExcelFile;
        private Button updateTrackingBtn;
        private OpenFileDialog UpdateTrackingExcelFile;
        private Panel wipTrackerChartPanel;
    }
}