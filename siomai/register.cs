﻿using System;
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
    public partial class register : Form
    {
        private string connectionString = "server=127.0.0.1; database=siomai; uid=root; pwd=axell;";

        public register()
        {
            InitializeComponent();
            register_Load(this, EventArgs.Empty); // Ensure questions are loaded
        }

        private void register_Load(object sender, EventArgs e)
        {
            // Add security questions to the ComboBox
            securityQuestionComboBox.Items.Add("What is your pet's name?");
            securityQuestionComboBox.Items.Add("What is your mother's maiden name?");
            securityQuestionComboBox.Items.Add("What city were you born in?");

            // Set default selection
            securityQuestionComboBox.SelectedIndex = 0;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            login loginForm = new login();
            loginForm.Show();
        }

        private bool IsPasswordComplex(string password)
        {
            if (password.Length < 8)
                return false;
            if (!password.Any(char.IsUpper))
                return false;
            if (!password.Any(char.IsLower))
                return false;
            if (!password.Any(char.IsDigit))
                return false;
            if (!password.Any(ch => !char.IsLetterOrDigit(ch)))
                return false;

            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;
            string confirmPassword = confirmPasswordTextBox.Text;
            string securityQuestion = securityQuestionComboBox.SelectedItem?.ToString();
            string securityAnswer = securityAnswerTextBox.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(securityAnswer))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }

            if (!IsPasswordComplex(password))
            {
                MessageBox.Show("Password must be at least 8 characters long and contain an uppercase letter, lowercase letter, digit, and special character.");
                return;
            }

            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);
            string hashedSecurityAnswer = BCrypt.Net.BCrypt.HashPassword(securityAnswer);

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string checkQuery = "SELECT COUNT(*) FROM log WHERE username = @username";
                    using (MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@username", username);
                        int userExists = Convert.ToInt32(checkCmd.ExecuteScalar());

                        if (userExists > 0)
                        {
                            MessageBox.Show("Username already exists. Choose another one.");
                            return;
                        }
                    }

                    string query = "INSERT INTO log (username, password, security_question, security_answer) VALUES (@username, @password, @security_question, @security_answer)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", hashedPassword);
                        cmd.Parameters.AddWithValue("@security_question", securityQuestion);
                        cmd.Parameters.AddWithValue("@security_answer", hashedSecurityAnswer);

                        int result = cmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Signup Successful!");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Signup Failed.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void securityQuestionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
