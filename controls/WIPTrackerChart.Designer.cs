namespace EyeonOps.controls
{
    partial class WIPTrackerChart
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
            topPanel = new Panel();
            chartPanel = new Panel();
            SuspendLayout();
            // 
            // topPanel
            // 
            topPanel.BackColor = SystemColors.Control;
            topPanel.Dock = DockStyle.Top;
            topPanel.Location = new Point(0, 0);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(150, 35);
            topPanel.TabIndex = 0;
            // 
            // chartPanel
            // 
            chartPanel.Dock = DockStyle.Fill;
            chartPanel.Location = new Point(0, 35);
            chartPanel.Name = "chartPanel";
            chartPanel.Size = new Size(150, 115);
            chartPanel.TabIndex = 0;
            // 
            // WIPTrackerChart
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(chartPanel);
            Controls.Add(topPanel);
            Name = "WIPTrackerChart";
            ResumeLayout(false);
        }

        #endregion

        private Panel topPanel;
        private Panel chartPanel;
    }
}
