using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BCrypt.Net;
using MySql.Data.MySqlClient;


namespace siomai
{
    public partial class login : Form


    {

        private string connectionString = "server=127.0.0.1; database=siomai; uid=root; pwd=axell;";
        public login()
        {
            InitializeComponent();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            register registerForm = new register();
            registerForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text.Trim();
            string password = passwordTextBox.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            // Check if admin login
            if (username == "ad" && password == "ad")
            {
                MessageBox.Show("Admin Login Successful!");
                AdminMenuForm adminForm = new AdminMenuForm();
                adminForm.Show();
                this.Hide();
                return;
            }
            if (username == "ax" && password == "ax")
            {
                MessageBox.Show("User Login Successful!");
                orderForm orderForm = new orderForm();
                orderForm.Show();
                this.Hide();
                return;
            }
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "SELECT password FROM log WHERE username = @username";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        var result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            string storedHashedPassword = result.ToString();

                            if (BCrypt.Net.BCrypt.Verify(password, storedHashedPassword))
                            {
                                MessageBox.Show("Login Successful!");

                                // Open order form after successful login
                                orderForm orderFormInstance = new orderForm();
                                orderFormInstance.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Incorrect password. Please try again.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Username not found.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }



        private void linkLabelRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            register registerForm = new register();
            registerForm.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            forgot forgotForm = new forgot ();
            forgotForm.Show();
            this.Hide();
        }
    }
}
