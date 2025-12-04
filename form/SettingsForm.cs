using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using EyeonOps.data;
using EyeonOps.models;

namespace EyeonOps.form
{
    public partial class SettingsForm : Form
    {
        private List<Setting> Settings;

        private string CreatePasswordHash(string password)
        {
            using (SHA256 sha = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(password);
                byte[] hash = sha.ComputeHash(bytes);
                StringBuilder sb = new StringBuilder();

                foreach (byte b in hash)
                    sb.Append(b.ToString("x2"));

                return sb.ToString();
            }
        }
        public SettingsForm()
        {
            InitializeComponent();
            Settings = new SettingAccess().GetAllSettings();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            foreach (Setting setting in Settings)
            {
                Panel panel = new Panel
                {
                    Height = 35,
                    Width = 300,
                    Margin = new Padding(5),
                    BackColor = Color.Transparent
                };

                Label settingLabel = new Label
                {
                    Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(setting.Key.Replace("-", " ")),
                    //AutoSize = false,
                    Width = 150,
                    //TextAlign = ContentAlignment.MiddleLeft,
                    Dock = DockStyle.Left,
                    Padding = new Padding(5, 0, 0, 0),
                    ForeColor = Color.White
                };

                Control valueInput;

                switch (setting.DataType)
                {
                    case "integer":
                        valueInput = new NumericUpDown()
                        {
                            Width = 40,
                            Value = decimal.TryParse(setting.Value, out var iVal) ? iVal : 0
                        };
                        break;

                    case "boolean":
                        valueInput = new CheckBox()
                        {
                            Checked = setting.Value.ToLower() == "true",
                            AutoSize = true
                        };
                        break;

                    case "datetime":
                        valueInput = new DateTimePicker()
                        {
                            Width = 150,
                            Value = DateTime.TryParse(setting.Value, out var dVal) ? dVal : DateTime.Now
                        };
                        break;

                    case "decimal":
                        valueInput = new NumericUpDown()
                        {
                            Width = 40,
                            DecimalPlaces = 2,
                            Value = decimal.TryParse(setting.Value, out var decVal) ? decVal : 0
                        };
                        break;

                    case "json":
                        valueInput = new ComboBox()
                        {
                            Width = 150,
                            DropDownStyle = ComboBoxStyle.DropDownList
                        };
                        break;

                    default:
                        valueInput = new TextBox()
                        {
                            Width = 150,
                            Text = setting.Value
                        };
                        break;
                }
                valueInput.Dock = DockStyle.Left;
                valueInput.Margin = new Padding(0, 5, 10, 5);

                panel.Controls.Add(valueInput);
                panel.Controls.Add(settingLabel);
                settingLayoutPanel.Controls.Add(panel);
            }
            LoadUsers();
        }

        private void addNewUserBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(username.Text))
            {
                MessageBox.Show("Username is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (username.Text.Contains(" "))
            {
                MessageBox.Show("Username cannot contain spaces.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(password.Text))
            {
                MessageBox.Show("Password is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(fullName.Text))
            {
                MessageBox.Show("Full Name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (userrole.SelectedItem == null)
            {
                MessageBox.Show("Please select a user role.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(email.Text))
            {
                MessageBox.Show("Email is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!Regex.IsMatch(email.Text.Trim(), @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Please enter a valid email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            User newUser = new User
            {
                Username = username.Text.Trim(),
                Password = CreatePasswordHash(password.Text),
                FullName = fullName.Text.Trim(),
                Role = userrole.SelectedItem?.ToString() ?? "User",
                Email = email.Text.Trim()
            };

            UserAccess userAccess = new UserAccess();
            bool success = userAccess.AddUser(newUser);

            if (success)
            {
                MessageBox.Show("User added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearBtn_Click(sender, e);
                LoadUsers();
            }
            else
                MessageBox.Show("Failed to add user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void userrole_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string selectedRole = userrole.SelectedItem?.ToString();

            //if (string.IsNullOrEmpty(selectedRole))
            //    return;

            //switch (selectedRole)
            //{
            //    case "Admin":
            //        MessageBox.Show("You selected Admin role.", "Role Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        break;

            //    case "Manager":
            //        MessageBox.Show("You selected Manager role.", "Role Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        break;

            //    default:
            //        MessageBox.Show($"You selected: {selectedRole}", "Role Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        break;
            //}
        }
        private void AddUserForm_Load(object sender, EventArgs e)
        {
            userrole.Items.Clear();
            userrole.Items.Add("Admin");
            userrole.Items.Add("Manager");
            userrole.SelectedIndex = 0;
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            username.Clear();
            password.Clear();
            fullName.Clear();
            userrole.SelectedIndex = -1;
            email.Clear();
        }

        private void ShowPasswordBtn_Click(object sender, EventArgs e)
        {
            password.UseSystemPasswordChar = !password.UseSystemPasswordChar;
            ShowPasswordBtn.Text = password.UseSystemPasswordChar ? "🙂" : "🫣";
        }
        public void LoadUsers()
        {
            userdataGridView.DataSource = new UserAccess().GetAllUsers(); 
        }

        private void userdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (userdataGridView.Columns[e.ColumnIndex].Name == "DataGridDelete")
            {
                User user = (User)userdataGridView.Rows[e.RowIndex].DataBoundItem;
                int userId = user.ID;

                DialogResult confirm = MessageBox.Show(
                    "Are you sure you want to delete this user?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    UserAccess userAccess = new UserAccess();
                    bool deleted = userAccess.DeleteUser(userId);

                    if (deleted)
                    {
                        MessageBox.Show("User deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadUsers();
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
