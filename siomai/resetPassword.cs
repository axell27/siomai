using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using BCrypt.Net;

namespace siomai
{
    public partial class resetPassword : Form
    {
        private string connectionString = "server=127.0.0.1; database=siomai; uid=root; pwd=axell;";
        private string currentUsername;

        public resetPassword(string username)
        {
            InitializeComponent();
            currentUsername = username;
        }

        private void resetPasswordButton_Click(object sender, EventArgs e)
        {
            string newPassword = newPasswordTextBox.Text.Trim();
            string confirmPassword = confirmPasswordTextBox.Text.Trim();

            if (string.IsNullOrEmpty(newPassword) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }

            if (!IsPasswordComplex(newPassword))
            {
                MessageBox.Show("Password must be at least 8 characters long and contain an uppercase letter, lowercase letter, digit, and special character.");
                return;
            }

            string hashedNewPassword = BCrypt.Net.BCrypt.HashPassword(newPassword);

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string updateQuery = "UPDATE log SET password = @password WHERE username = @username";
                    using (MySqlCommand cmd = new MySqlCommand(updateQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@password", hashedNewPassword);
                        cmd.Parameters.AddWithValue("@username", currentUsername);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Password reset successful! You can now log in.");
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private bool IsPasswordComplex(string password)
        {
            return password.Length >= 8 &&
                   password.Any(char.IsUpper) &&
                   password.Any(char.IsLower) &&
                   password.Any(char.IsDigit) &&
                   password.Any(ch => !char.IsLetterOrDigit(ch));
        }
    }
}