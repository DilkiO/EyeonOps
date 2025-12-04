namespace EyeonOps.controls
{
    partial class OperatorVisual
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelEPFName = new Label();
            labelStatus = new Label();
            labelSampleRoom = new Label();
            labelGrade = new Label();
            labelSkill = new Label();
            labelIdleTime = new Label();
            lmage = new Label();
            SuspendLayout();
            // 
            // labelEPFName
            // 
            labelEPFName.BackColor = Color.Transparent;
            labelEPFName.ForeColor = Color.Black;
            labelEPFName.Location = new Point(0, 60);
            labelEPFName.Margin = new Padding(0);
            labelEPFName.Name = "labelEPFName";
            labelEPFName.Size = new Size(184, 23);
            labelEPFName.TabIndex = 0;
            labelEPFName.Text = "EPF-Name";
            labelEPFName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelStatus
            // 
            labelStatus.BackColor = Color.Transparent;
            labelStatus.ForeColor = Color.Black;
            labelStatus.Location = new Point(0, 83);
            labelStatus.Margin = new Padding(0);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(184, 23);
            labelStatus.TabIndex = 1;
            labelStatus.Text = "Status";
            labelStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelSampleRoom
            // 
            labelSampleRoom.BackColor = Color.Transparent;
            labelSampleRoom.ForeColor = Color.Black;
            labelSampleRoom.Location = new Point(0, 106);
            labelSampleRoom.Margin = new Padding(0);
            labelSampleRoom.Name = "labelSampleRoom";
            labelSampleRoom.Size = new Size(184, 23);
            labelSampleRoom.TabIndex = 2;
            labelSampleRoom.Text = "Sample Room";
            labelSampleRoom.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelGrade
            // 
            labelGrade.BackColor = Color.Transparent;
            labelGrade.ForeColor = Color.Black;
            labelGrade.Location = new Point(0, 129);
            labelGrade.Margin = new Padding(0);
            labelGrade.Name = "labelGrade";
            labelGrade.Size = new Size(184, 23);
            labelGrade.TabIndex = 3;
            labelGrade.Text = "Grade";
            labelGrade.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelSkill
            // 
            labelSkill.BackColor = Color.Transparent;
            labelSkill.ForeColor = Color.Black;
            labelSkill.Location = new Point(0, 152);
            labelSkill.Margin = new Padding(0);
            labelSkill.Name = "labelSkill";
            labelSkill.Size = new Size(184, 23);
            labelSkill.TabIndex = 4;
            labelSkill.Text = "Skill";
            labelSkill.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelIdleTime
            // 
            labelIdleTime.BackColor = Color.Transparent;
            labelIdleTime.ForeColor = Color.Black;
            labelIdleTime.Location = new Point(0, 175);
            labelIdleTime.Margin = new Padding(0);
            labelIdleTime.Name = "labelIdleTime";
            labelIdleTime.Size = new Size(184, 23);
            labelIdleTime.TabIndex = 5;
            labelIdleTime.Text = "Idle Time";
            labelIdleTime.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lmage
            // 
            lmage.BackColor = Color.Transparent;
            lmage.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lmage.ForeColor = Color.Black;
            lmage.Location = new Point(0, 0);
            lmage.Margin = new Padding(0);
            lmage.Name = "lmage";
            lmage.Size = new Size(184, 60);
            lmage.TabIndex = 6;
            lmage.Text = "‍👤";
            lmage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // OperatorVisual
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(lmage);
            Controls.Add(labelIdleTime);
            Controls.Add(labelSkill);
            Controls.Add(labelGrade);
            Controls.Add(labelSampleRoom);
            Controls.Add(labelStatus);
            Controls.Add(labelEPFName);
            Margin = new Padding(8);
            Name = "OperatorVisual";
            Size = new Size(184, 208);
            Load += OperatorView_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label labelEPFName;
        private Label labelStatus;
        private Label labelSampleRoom;
        private Label labelGrade;
        private Label labelSkill;
        private Label labelIdleTime;
        private Label lmage;
    }
}
