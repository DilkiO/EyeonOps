using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EyeonOps.data;
using EyeonOps.models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace EyeonOps.form
{
    public partial class Loginform : Form
    {
        public Loginform()
        {
            InitializeComponent();
        }

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

        public bool VerifyPassword(string enteredPassword, string storedHash)
        {
            string enteredHash = CreatePasswordHash(enteredPassword);
            return enteredHash.Equals(storedHash, StringComparison.OrdinalIgnoreCase);
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string username = UserNameInput.Text.Trim();
            string password = PasswordInput.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            User user = new UserAccess().GetUserbyUserName(username);

            if (user == null)
            {
                MessageBox.Show("User not found!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!user.Active)
            {
                MessageBox.Show("This user is inactive.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            bool isPasswordCorrect = VerifyPassword(password, user.Password);

            if (isPasswordCorrect)
            {
                this.Hide();
                MainLayoutForm MainForm = new MainLayoutForm();
                MainForm.Show();
            }
            else
            {
                MessageBox.Show("Incorrect password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            UserNameInput.Clear();
            PasswordInput.Clear();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ShowPasswordBtn_Click(object sender, EventArgs e)
        {
            PasswordInput.UseSystemPasswordChar=!PasswordInput.UseSystemPasswordChar;
            ShowPasswordBtn.Text = PasswordInput.UseSystemPasswordChar ? "🙂" : "🫣";
        }
    }
}
