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
    public partial class securityQuestion : Form
    {
        private string connectionString = "server=127.0.0.1; database=siomai; uid=root; pwd=axell;";
        private string currentUsername = "";
        private string storedSecurityAnswer = "";
        private string generatedOTP = "";
        private DateTime otpExpirationTime;

        public securityQuestion(string username)
        {
            InitializeComponent();
            currentUsername = username;
            LoadSecurityQuestion();
        }

        private void LoadSecurityQuestion()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT security_question, security_answer FROM log WHERE username = @username";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", currentUsername);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                securityQuestionLabel.Text = reader.GetString(0); // Display security question
                                storedSecurityAnswer = reader.GetString(1); // Store hashed answer
                            }
                            else
                            {
                                MessageBox.Show("Security question not found.");
                                this.Close();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void verifyAnswerButton_Click(object sender, EventArgs e)
        {
            string securityAnswer = securityAnswerTextBox.Text.Trim();

            if (string.IsNullOrEmpty(securityAnswer))
            {
                MessageBox.Show("Please enter your security answer.");
                return;
            }

            if (BCrypt.Net.BCrypt.Verify(securityAnswer, storedSecurityAnswer))
            {
                GenerateOTP();
            }
            else
            {
                MessageBox.Show("Incorrect security answer.");
            }
        }

        private void GenerateOTP()
        {
            Random random = new Random();
            generatedOTP = random.Next(100000, 999999).ToString(); 
            otpExpirationTime = DateTime.Now.AddMinutes(2); 

            MessageBox.Show($"Your OTP is: {generatedOTP}\nIt will expire in 2 minutes.", "OTP Generated");

            this.Hide();
            verifyOTP verifyOtpForm = new verifyOTP(currentUsername, generatedOTP, otpExpirationTime);
            verifyOtpForm.Show();
        }
    }
}
