namespace EyeonOps.form
{
    partial class SettingsForm
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
            settingLayoutPanel = new FlowLayoutPanel();
            addNewUserBtn = new Button();
            username = new TextBox();
            userlabel = new Label();
            passwordlabel = new Label();
            password = new TextBox();
            fullnamelabel = new Label();
            fullName = new TextBox();
            rolelabel = new Label();
            userrole = new ComboBox();
            emailLable = new Label();
            email = new TextBox();
            clearBtn = new Button();
            ShowPasswordBtn = new Button();
            userdataGridView = new DataGridView();
            DataGridPassword = new DataGridViewTextBoxColumn();
            DataGridDelete = new DataGridViewButtonColumn();
            DataGridID = new DataGridViewTextBoxColumn();
            DataGridUsername = new DataGridViewTextBoxColumn();
            DataGridFullName = new DataGridViewTextBoxColumn();
            DataGridRole = new DataGridViewTextBoxColumn();
            DataGridActive = new DataGridViewCheckBoxColumn();
            DataGridCreatedAt = new DataGridViewTextBoxColumn();
            DataGridEmail = new DataGridViewTextBoxColumn();
            DataGridUpdatedAt = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)userdataGridView).BeginInit();
            SuspendLayout();
            // 
            // settingLayoutPanel
            // 
            settingLayoutPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            settingLayoutPanel.AutoScroll = true;
            settingLayoutPanel.BackColor = Color.Transparent;
            settingLayoutPanel.BackgroundImageLayout = ImageLayout.Stretch;
            settingLayoutPanel.FlowDirection = FlowDirection.TopDown;
            settingLayoutPanel.Location = new Point(12, 12);
            settingLayoutPanel.Name = "settingLayoutPanel";
            settingLayoutPanel.Size = new Size(450, 77);
            settingLayoutPanel.TabIndex = 0;
            settingLayoutPanel.WrapContents = false;
            // 
            // addNewUserBtn
            // 
            addNewUserBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            addNewUserBtn.AutoSize = true;
            addNewUserBtn.BackColor = Color.Lime;
            addNewUserBtn.FlatStyle = FlatStyle.Flat;
            addNewUserBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addNewUserBtn.ForeColor = Color.Black;
            addNewUserBtn.Location = new Point(504, 354);
            addNewUserBtn.Name = "addNewUserBtn";
            addNewUserBtn.Size = new Size(92, 32);
            addNewUserBtn.TabIndex = 0;
            addNewUserBtn.Text = "Add User";
            addNewUserBtn.UseVisualStyleBackColor = false;
            addNewUserBtn.Click += addNewUserBtn_Click;
            // 
            // username
            // 
            username.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            username.Location = new Point(602, 80);
            username.Name = "username";
            username.Size = new Size(173, 23);
            username.TabIndex = 1;
            // 
            // userlabel
            // 
            userlabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            userlabel.AutoSize = true;
            userlabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            userlabel.ForeColor = Color.White;
            userlabel.Location = new Point(468, 79);
            userlabel.Name = "userlabel";
            userlabel.Size = new Size(128, 20);
            userlabel.TabIndex = 2;
            userlabel.Text = "Enter User Name";
            // 
            // passwordlabel
            // 
            passwordlabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            passwordlabel.AutoSize = true;
            passwordlabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            passwordlabel.ForeColor = Color.White;
            passwordlabel.Location = new Point(469, 138);
            passwordlabel.Name = "passwordlabel";
            passwordlabel.Size = new Size(117, 20);
            passwordlabel.TabIndex = 3;
            passwordlabel.Text = "Enter Password";
            // 
            // password
            // 
            password.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            password.Location = new Point(602, 135);
            password.Name = "password";
            password.Size = new Size(173, 23);
            password.TabIndex = 4;
            password.UseSystemPasswordChar = true;
            // 
            // fullnamelabel
            // 
            fullnamelabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            fullnamelabel.AutoSize = true;
            fullnamelabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            fullnamelabel.ForeColor = Color.White;
            fullnamelabel.Location = new Point(469, 191);
            fullnamelabel.Name = "fullnamelabel";
            fullnamelabel.Size = new Size(121, 20);
            fullnamelabel.TabIndex = 5;
            fullnamelabel.Text = "Enter Full Name";
            // 
            // fullName
            // 
            fullName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            fullName.Location = new Point(602, 188);
            fullName.Name = "fullName";
            fullName.Size = new Size(173, 23);
            fullName.TabIndex = 6;
            // 
            // rolelabel
            // 
            rolelabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            rolelabel.AutoSize = true;
            rolelabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            rolelabel.ForeColor = Color.White;
            rolelabel.Location = new Point(469, 243);
            rolelabel.Name = "rolelabel";
            rolelabel.Size = new Size(121, 20);
            rolelabel.TabIndex = 7;
            rolelabel.Text = "Select User Role";
            // 
            // userrole
            // 
            userrole.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            userrole.FormattingEnabled = true;
            userrole.Items.AddRange(new object[] { "Admin", "Manager" });
            userrole.Location = new Point(602, 240);
            userrole.Name = "userrole";
            userrole.Size = new Size(173, 23);
            userrole.TabIndex = 8;
            userrole.SelectedIndexChanged += userrole_SelectedIndexChanged;
            // 
            // emailLable
            // 
            emailLable.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            emailLable.AutoSize = true;
            emailLable.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            emailLable.ForeColor = Color.White;
            emailLable.Location = new Point(469, 295);
            emailLable.Name = "emailLable";
            emailLable.Size = new Size(88, 20);
            emailLable.TabIndex = 9;
            emailLable.Text = "Enter Email";
            // 
            // email
            // 
            email.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            email.Location = new Point(602, 292);
            email.Name = "email";
            email.Size = new Size(173, 23);
            email.TabIndex = 10;
            // 
            // clearBtn
            // 
            clearBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            clearBtn.AutoSize = true;
            clearBtn.BackColor = Color.Red;
            clearBtn.FlatStyle = FlatStyle.Flat;
            clearBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clearBtn.ForeColor = Color.White;
            clearBtn.Location = new Point(683, 354);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(92, 32);
            clearBtn.TabIndex = 11;
            clearBtn.Text = "Clear All";
            clearBtn.UseVisualStyleBackColor = false;
            clearBtn.Click += clearBtn_Click;
            // 
            // ShowPasswordBtn
            // 
            ShowPasswordBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ShowPasswordBtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ShowPasswordBtn.ForeColor = Color.Black;
            ShowPasswordBtn.Location = new Point(749, 133);
            ShowPasswordBtn.Margin = new Padding(0);
            ShowPasswordBtn.Name = "ShowPasswordBtn";
            ShowPasswordBtn.Size = new Size(26, 25);
            ShowPasswordBtn.TabIndex = 12;
            ShowPasswordBtn.Text = "🙂";
            ShowPasswordBtn.UseVisualStyleBackColor = true;
            ShowPasswordBtn.Click += ShowPasswordBtn_Click;
            // 
            // userdataGridView
            // 
            userdataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            userdataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            userdataGridView.BackgroundColor = Color.FromArgb(0, 0, 64);
            userdataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            userdataGridView.Columns.AddRange(new DataGridViewColumn[] { DataGridPassword, DataGridDelete, DataGridID, DataGridUsername, DataGridFullName, DataGridRole, DataGridActive, DataGridCreatedAt, DataGridEmail, DataGridUpdatedAt });
            userdataGridView.Location = new Point(12, 95);
            userdataGridView.Name = "userdataGridView";
            userdataGridView.Size = new Size(450, 289);
            userdataGridView.TabIndex = 13;
            userdataGridView.CellContentClick += userdataGridView_CellContentClick;
            // 
            // DataGridPassword
            // 
            DataGridPassword.DataPropertyName = "Password";
            DataGridPassword.HeaderText = "Password";
            DataGridPassword.Name = "DataGridPassword";
            DataGridPassword.Visible = false;
            DataGridPassword.Width = 82;
            // 
            // DataGridDelete
            // 
            DataGridDelete.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DataGridDelete.DataPropertyName = "Delete";
            DataGridDelete.HeaderText = "Delete";
            DataGridDelete.Name = "DataGridDelete";
            DataGridDelete.Resizable = DataGridViewTriState.True;
            DataGridDelete.SortMode = DataGridViewColumnSortMode.Automatic;
            DataGridDelete.Text = "🗑️";
            DataGridDelete.UseColumnTextForButtonValue = true;
            DataGridDelete.Width = 65;
            // 
            // DataGridID
            // 
            DataGridID.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DataGridID.DataPropertyName = "ID";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DataGridID.DefaultCellStyle = dataGridViewCellStyle1;
            DataGridID.HeaderText = "ID";
            DataGridID.Name = "DataGridID";
            DataGridID.Width = 43;
            // 
            // DataGridUsername
            // 
            DataGridUsername.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DataGridUsername.DataPropertyName = "Username";
            DataGridUsername.HeaderText = "Username";
            DataGridUsername.Name = "DataGridUsername";
            // 
            // DataGridFullName
            // 
            DataGridFullName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DataGridFullName.DataPropertyName = "FullName";
            DataGridFullName.HeaderText = "FullName";
            DataGridFullName.Name = "DataGridFullName";
            // 
            // DataGridRole
            // 
            DataGridRole.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DataGridRole.DataPropertyName = "Role";
            DataGridRole.HeaderText = "Role";
            DataGridRole.Name = "DataGridRole";
            // 
            // DataGridActive
            // 
            DataGridActive.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DataGridActive.DataPropertyName = "Active";
            DataGridActive.HeaderText = "Active";
            DataGridActive.Name = "DataGridActive";
            DataGridActive.Resizable = DataGridViewTriState.True;
            DataGridActive.SortMode = DataGridViewColumnSortMode.Automatic;
            DataGridActive.Visible = false;
            // 
            // DataGridCreatedAt
            // 
            DataGridCreatedAt.DataPropertyName = "CreatedAt";
            DataGridCreatedAt.HeaderText = "CreatedAt";
            DataGridCreatedAt.Name = "DataGridCreatedAt";
            DataGridCreatedAt.Visible = false;
            DataGridCreatedAt.Width = 85;
            // 
            // DataGridEmail
            // 
            DataGridEmail.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DataGridEmail.DataPropertyName = "Email";
            DataGridEmail.HeaderText = "Email";
            DataGridEmail.Name = "DataGridEmail";
            // 
            // DataGridUpdatedAt
            // 
            DataGridUpdatedAt.DataPropertyName = "UpdatedAt";
            DataGridUpdatedAt.HeaderText = "UpdatedAt";
            DataGridUpdatedAt.Name = "DataGridUpdatedAt";
            DataGridUpdatedAt.Visible = false;
            DataGridUpdatedAt.Width = 89;
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 64);
            ClientSize = new Size(800, 450);
            Controls.Add(userdataGridView);
            Controls.Add(ShowPasswordBtn);
            Controls.Add(clearBtn);
            Controls.Add(email);
            Controls.Add(emailLable);
            Controls.Add(userrole);
            Controls.Add(rolelabel);
            Controls.Add(fullName);
            Controls.Add(fullnamelabel);
            Controls.Add(password);
            Controls.Add(passwordlabel);
            Controls.Add(userlabel);
            Controls.Add(username);
            Controls.Add(addNewUserBtn);
            Controls.Add(settingLayoutPanel);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.None;
            Name = "SettingsForm";
            Text = "SettingsForm";
            Load += SettingsForm_Load;
            ((System.ComponentModel.ISupportInitialize)userdataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel settingLayoutPanel;
        private Button addNewUserBtn;
        private TextBox username;
        private Label userlabel;
        private Label passwordlabel;
        private TextBox password;
        private Label fullnamelabel;
        private TextBox fullName;
        private Label rolelabel;
        private ComboBox userrole;
        private Label emailLable;
        private TextBox email;
        private Button clearBtn;
        private Button ShowPasswordBtn;
        private DataGridView userdataGridView;
        private DataGridViewTextBoxColumn DataGridPassword;
        private DataGridViewButtonColumn DataGridDelete;
        private DataGridViewTextBoxColumn DataGridID;
        private DataGridViewTextBoxColumn DataGridUsername;
        private DataGridViewTextBoxColumn DataGridFullName;
        private DataGridViewTextBoxColumn DataGridRole;
        private DataGridViewCheckBoxColumn DataGridActive;
        private DataGridViewTextBoxColumn DataGridCreatedAt;
        private DataGridViewTextBoxColumn DataGridEmail;
        private DataGridViewTextBoxColumn DataGridUpdatedAt;
    }
}