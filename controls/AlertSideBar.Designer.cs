namespace EyeonOps.controls
{
    partial class alertSideBarControl
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
            alterContainerPanel = new FlowLayoutPanel();
            clearAllBtn = new Button();
            SuspendLayout();
            // 
            // alterContainerPanel
            // 
            alterContainerPanel.AutoScroll = true;
            alterContainerPanel.BackColor = Color.Navy;
            alterContainerPanel.Dock = DockStyle.Fill;
            alterContainerPanel.Location = new Point(0, 0);
            alterContainerPanel.Name = "alterContainerPanel";
            alterContainerPanel.Size = new Size(331, 600);
            alterContainerPanel.TabIndex = 0;
            // 
            // clearAllBtn
            // 
            clearAllBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            clearAllBtn.BackColor = Color.Blue;
            clearAllBtn.FlatAppearance.BorderSize = 0;
            clearAllBtn.FlatStyle = FlatStyle.Flat;
            clearAllBtn.ForeColor = Color.White;
            clearAllBtn.Location = new Point(250, 570);
            clearAllBtn.Name = "clearAllBtn";
            clearAllBtn.Size = new Size(75, 23);
            clearAllBtn.TabIndex = 1;
            clearAllBtn.Text = "Clear All";
            clearAllBtn.UseVisualStyleBackColor = false;
            clearAllBtn.Click += clearAllBtn_Click;
            // 
            // alertSideBarControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(clearAllBtn);
            Controls.Add(alterContainerPanel);
            Name = "alertSideBarControl";
            Size = new Size(331, 600);
            Load += alertSideBarControl_Load;
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel alterContainerPanel;
        private Button clearAllBtn;
    }
}
