namespace EyeonOps.form
{
    partial class MainLayoutForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainLayoutForm));
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            DashboardBtn = new Button();
            panel2 = new Panel();
            WIPTrackerBtn = new Button();
            panel5 = new Panel();
            operatorsBtn = new Button();
            panel3 = new Panel();
            AssignmentBtn = new Button();
            panel4 = new Panel();
            SettingsBtn = new Button();
            pictureBox1 = new PictureBox();
            eyeonopstlabel = new Label();
            FormLoadMainLayout = new Panel();
            updateoperatorstatustimer = new System.Windows.Forms.Timer(components);
            alertBtn = new Button();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(0, 0, 64);
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Controls.Add(panel2);
            flowLayoutPanel1.Controls.Add(panel5);
            flowLayoutPanel1.Controls.Add(panel3);
            flowLayoutPanel1.Controls.Add(panel4);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Margin = new Padding(0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(10);
            flowLayoutPanel1.Size = new Size(200, 618);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(DashboardBtn);
            panel1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.ForeColor = Color.Black;
            panel1.Location = new Point(10, 10);
            panel1.Margin = new Padding(0, 0, 0, 10);
            panel1.Name = "panel1";
            panel1.Size = new Size(180, 60);
            panel1.TabIndex = 1;
            // 
            // DashboardBtn
            // 
            DashboardBtn.BackColor = Color.FromArgb(0, 0, 64);
            DashboardBtn.Dock = DockStyle.Fill;
            DashboardBtn.FlatAppearance.BorderSize = 0;
            DashboardBtn.FlatStyle = FlatStyle.Flat;
            DashboardBtn.ForeColor = Color.White;
            DashboardBtn.Location = new Point(0, 0);
            DashboardBtn.Margin = new Padding(0);
            DashboardBtn.Name = "DashboardBtn";
            DashboardBtn.Padding = new Padding(10, 0, 0, 0);
            DashboardBtn.Size = new Size(180, 60);
            DashboardBtn.TabIndex = 0;
            DashboardBtn.Text = "\U0001fa9f   Dashboard";
            DashboardBtn.TextAlign = ContentAlignment.MiddleLeft;
            DashboardBtn.UseVisualStyleBackColor = false;
            DashboardBtn.Click += DashboardBtn_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 0, 64);
            panel2.Controls.Add(WIPTrackerBtn);
            panel2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel2.Location = new Point(10, 80);
            panel2.Margin = new Padding(0, 0, 0, 10);
            panel2.Name = "panel2";
            panel2.Size = new Size(180, 60);
            panel2.TabIndex = 2;
            // 
            // WIPTrackerBtn
            // 
            WIPTrackerBtn.BackColor = Color.FromArgb(0, 0, 64);
            WIPTrackerBtn.Dock = DockStyle.Fill;
            WIPTrackerBtn.FlatAppearance.BorderSize = 0;
            WIPTrackerBtn.FlatStyle = FlatStyle.Flat;
            WIPTrackerBtn.ForeColor = Color.White;
            WIPTrackerBtn.Location = new Point(0, 0);
            WIPTrackerBtn.Margin = new Padding(0);
            WIPTrackerBtn.Name = "WIPTrackerBtn";
            WIPTrackerBtn.Padding = new Padding(10, 0, 0, 0);
            WIPTrackerBtn.Size = new Size(180, 60);
            WIPTrackerBtn.TabIndex = 0;
            WIPTrackerBtn.Text = "📊   WIP Tracker";
            WIPTrackerBtn.TextAlign = ContentAlignment.MiddleLeft;
            WIPTrackerBtn.UseVisualStyleBackColor = false;
            WIPTrackerBtn.Click += WIPTrackerBtn_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(0, 0, 64);
            panel5.Controls.Add(operatorsBtn);
            panel5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel5.Location = new Point(10, 150);
            panel5.Margin = new Padding(0, 0, 0, 10);
            panel5.Name = "panel5";
            panel5.Size = new Size(180, 60);
            panel5.TabIndex = 5;
            // 
            // operatorsBtn
            // 
            operatorsBtn.Dock = DockStyle.Fill;
            operatorsBtn.FlatAppearance.BorderSize = 0;
            operatorsBtn.FlatStyle = FlatStyle.Flat;
            operatorsBtn.ForeColor = Color.White;
            operatorsBtn.Location = new Point(0, 0);
            operatorsBtn.Margin = new Padding(0);
            operatorsBtn.Name = "operatorsBtn";
            operatorsBtn.Padding = new Padding(10, 0, 0, 0);
            operatorsBtn.Size = new Size(180, 60);
            operatorsBtn.TabIndex = 0;
            operatorsBtn.Text = "👥   Operators";
            operatorsBtn.TextAlign = ContentAlignment.MiddleLeft;
            operatorsBtn.UseVisualStyleBackColor = true;
            operatorsBtn.Click += operatorsBtn_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(AssignmentBtn);
            panel3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel3.Location = new Point(10, 220);
            panel3.Margin = new Padding(0, 0, 0, 10);
            panel3.Name = "panel3";
            panel3.Size = new Size(180, 60);
            panel3.TabIndex = 3;
            // 
            // AssignmentBtn
            // 
            AssignmentBtn.Dock = DockStyle.Fill;
            AssignmentBtn.FlatAppearance.BorderSize = 0;
            AssignmentBtn.FlatStyle = FlatStyle.Flat;
            AssignmentBtn.ForeColor = Color.White;
            AssignmentBtn.Location = new Point(0, 0);
            AssignmentBtn.Margin = new Padding(0);
            AssignmentBtn.Name = "AssignmentBtn";
            AssignmentBtn.Padding = new Padding(10, 0, 0, 0);
            AssignmentBtn.Size = new Size(180, 60);
            AssignmentBtn.TabIndex = 0;
            AssignmentBtn.Text = "📑   ‍Assignment";
            AssignmentBtn.TextAlign = ContentAlignment.MiddleLeft;
            AssignmentBtn.UseVisualStyleBackColor = true;
            AssignmentBtn.Click += AssignmentBtn_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(SettingsBtn);
            panel4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel4.Location = new Point(10, 290);
            panel4.Margin = new Padding(0, 0, 0, 10);
            panel4.Name = "panel4";
            panel4.Size = new Size(180, 60);
            panel4.TabIndex = 4;
            // 
            // SettingsBtn
            // 
            SettingsBtn.Dock = DockStyle.Fill;
            SettingsBtn.FlatAppearance.BorderSize = 0;
            SettingsBtn.FlatStyle = FlatStyle.Flat;
            SettingsBtn.ForeColor = Color.White;
            SettingsBtn.Location = new Point(0, 0);
            SettingsBtn.Margin = new Padding(0);
            SettingsBtn.Name = "SettingsBtn";
            SettingsBtn.Padding = new Padding(10, 0, 0, 0);
            SettingsBtn.Size = new Size(180, 60);
            SettingsBtn.TabIndex = 0;
            SettingsBtn.Text = "⚙️   Settings";
            SettingsBtn.TextAlign = ContentAlignment.MiddleLeft;
            SettingsBtn.UseVisualStyleBackColor = true;
            SettingsBtn.Click += SettingsBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(15, 365);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(174, 153);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // eyeonopstlabel
            // 
            eyeonopstlabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            eyeonopstlabel.AutoSize = true;
            eyeonopstlabel.BackColor = Color.Transparent;
            eyeonopstlabel.Font = new Font("Jokerman", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            eyeonopstlabel.ForeColor = Color.White;
            eyeonopstlabel.Location = new Point(15, 521);
            eyeonopstlabel.Name = "eyeonopstlabel";
            eyeonopstlabel.Size = new Size(172, 43);
            eyeonopstlabel.TabIndex = 7;
            eyeonopstlabel.Text = "EyeOnOps";
            // 
            // FormLoadMainLayout
            // 
            FormLoadMainLayout.BackColor = Color.FromArgb(0, 0, 64);
            FormLoadMainLayout.BackgroundImageLayout = ImageLayout.Zoom;
            FormLoadMainLayout.Dock = DockStyle.Fill;
            FormLoadMainLayout.Location = new Point(200, 0);
            FormLoadMainLayout.Name = "FormLoadMainLayout";
            FormLoadMainLayout.Size = new Size(880, 618);
            FormLoadMainLayout.TabIndex = 1;
            // 
            // updateoperatorstatustimer
            // 
            updateoperatorstatustimer.Interval = 2000;
            updateoperatorstatustimer.Tick += updateoperatorstatustimer_Tick;
            // 
            // alertBtn
            // 
            alertBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            alertBtn.AutoSize = true;
            alertBtn.BackColor = Color.FromArgb(192, 0, 0);
            alertBtn.FlatStyle = FlatStyle.Flat;
            alertBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            alertBtn.ForeColor = Color.White;
            alertBtn.Location = new Point(60, 584);
            alertBtn.Margin = new Padding(0);
            alertBtn.Name = "alertBtn";
            alertBtn.Size = new Size(75, 27);
            alertBtn.TabIndex = 8;
            alertBtn.Text = "🔔 Alerts";
            alertBtn.UseVisualStyleBackColor = false;
            alertBtn.Click += alertBtn_Click;
            // 
            // MainLayoutForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 64);
            ClientSize = new Size(1080, 618);
            Controls.Add(alertBtn);
            Controls.Add(FormLoadMainLayout);
            Controls.Add(pictureBox1);
            Controls.Add(eyeonopstlabel);
            Controls.Add(flowLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainLayoutForm";
            Text = "EyeonOps";
            FormClosed += MainLayoutForm_FormClosed;
            Load += MainLayoutForm_Load;
            flowLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private Button DashboardBtn;
        private Panel panel2;
        private Button WIPTrackerBtn;
        private Panel panel3;
        private Button AssignmentBtn;
        private Panel panel4;
        private Button SettingsBtn;
        private Panel FormLoadMainLayout;
        private Panel panel5;
        private Button operatorsBtn;
        private PictureBox pictureBox1;
        private Label eyeonopstlabel;
        private System.Windows.Forms.Timer updateoperatorstatustimer;
        private Button alertBtn;
    }
}