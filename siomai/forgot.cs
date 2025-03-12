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

namespace siomai
{
    public partial class forgot : Form
    {
        private string connectionString = "server=127.0.0.1; database=siomai; uid=root; pwd=axell;";

        public forgot()
        {
            InitializeComponent();
        }

        private void checkUsernameButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text.Trim();

            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Please enter your username.");
                return;
            }

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM log WHERE username = @username";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        int userCount = Convert.ToInt32(cmd.ExecuteScalar());

                        if (userCount > 0)
                        {
                            this.Hide();
                            securityQuestion securityForm = new securityQuestion(username);
                            securityForm.Show();
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
    }
}