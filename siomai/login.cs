﻿using System;
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
    }
}
