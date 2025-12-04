namespace EyeonOps.form
{
    partial class Loginform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loginform));
            UserNameInput = new TextBox();
            PasswordInput = new TextBox();
            label1 = new Label();
            label2 = new Label();
            LoginBtn = new Button();
            ExitBtn = new Button();
            label3 = new Label();
            ShowPasswordBtn = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // UserNameInput
            // 
            UserNameInput.Font = new Font("Segoe UI", 9.75F);
            UserNameInput.ForeColor = Color.Black;
            UserNameInput.Location = new Point(63, 162);
            UserNameInput.Name = "UserNameInput";
            UserNameInput.Size = new Size(190, 25);
            UserNameInput.TabIndex = 0;
            // 
            // PasswordInput
            // 
            PasswordInput.Font = new Font("Segoe UI", 9.75F);
            PasswordInput.ForeColor = Color.Black;
            PasswordInput.Location = new Point(63, 231);
            PasswordInput.Name = "PasswordInput";
            PasswordInput.Size = new Size(190, 25);
            PasswordInput.TabIndex = 1;
            PasswordInput.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F);
            label1.Location = new Point(63, 132);
            label1.Name = "label1";
            label1.Size = new Size(67, 17);
            label1.TabIndex = 2;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F);
            label2.Location = new Point(63, 202);
            label2.Name = "label2";
            label2.Size = new Size(64, 17);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // LoginBtn
            // 
            LoginBtn.BackColor = Color.Lime;
            LoginBtn.FlatAppearance.BorderSize = 0;
            LoginBtn.FlatStyle = FlatStyle.Flat;
            LoginBtn.Font = new Font("Segoe UI", 9.75F);
            LoginBtn.ForeColor = Color.Black;
            LoginBtn.Location = new Point(63, 316);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(75, 31);
            LoginBtn.TabIndex = 4;
            LoginBtn.Text = "Login";
            LoginBtn.UseVisualStyleBackColor = false;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // ExitBtn
            // 
            ExitBtn.BackColor = Color.Red;
            ExitBtn.FlatAppearance.BorderSize = 0;
            ExitBtn.FlatStyle = FlatStyle.Flat;
            ExitBtn.Font = new Font("Segoe UI", 9.75F);
            ExitBtn.ForeColor = Color.White;
            ExitBtn.Location = new Point(178, 316);
            ExitBtn.Name = "ExitBtn";
            ExitBtn.Size = new Size(75, 29);
            ExitBtn.TabIndex = 5;
            ExitBtn.Text = "Exit";
            ExitBtn.UseVisualStyleBackColor = false;
            ExitBtn.Click += ExitBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(118, 81);
            label3.Name = "label3";
            label3.Size = new Size(69, 30);
            label3.TabIndex = 6;
            label3.Text = "Login";
            // 
            // ShowPasswordBtn
            // 
            ShowPasswordBtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ShowPasswordBtn.ForeColor = Color.Black;
            ShowPasswordBtn.Location = new Point(227, 231);
            ShowPasswordBtn.Margin = new Padding(0);
            ShowPasswordBtn.Name = "ShowPasswordBtn";
            ShowPasswordBtn.Size = new Size(26, 25);
            ShowPasswordBtn.TabIndex = 7;
            ShowPasswordBtn.Text = "🙂";
            ShowPasswordBtn.UseVisualStyleBackColor = true;
            ShowPasswordBtn.Click += ShowPasswordBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(118, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(71, 48);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // Loginform
            // 
            AcceptButton = LoginBtn;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 64);
            CancelButton = ExitBtn;
            ClientSize = new Size(311, 377);
            ControlBox = false;
            Controls.Add(pictureBox1);
            Controls.Add(ShowPasswordBtn);
            Controls.Add(label3);
            Controls.Add(ExitBtn);
            Controls.Add(LoginBtn);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(PasswordInput);
            Controls.Add(UserNameInput);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Loginform";
            Text = "EyeonOps";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox UserNameInput;
        private TextBox PasswordInput;
        private Label label1;
        private Label label2;
        private Button LoginBtn;
        private Button ExitBtn;
        private Label label3;
        private Button ShowPasswordBtn;
        private PictureBox pictureBox1;
    }
}