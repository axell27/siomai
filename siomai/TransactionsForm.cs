using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace siomai
{
    public partial class TransactionsForm : Form
    {
        public TransactionsForm()
        {
            InitializeComponent();
        }

        // Method to load and display transactions
        public void LoadTransactions()
        {
            string connStr = "server=127.0.0.1; database=siomai; uid=root; pwd=axell;";
            string query = "SELECT * FROM transactions"; // Adjust table name if needed
            using (var connection = new MySqlConnection(connStr))
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                transactionsDataGridView.DataSource = dataTable; // Binding data to DataGridView
            }
        }

        // Optionally, you can call this method when the form loads
        private void TransactionsForm_Load(object sender, EventArgs e)
        {
            LoadTransactions();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminMenuForm adminMenuForm = new AdminMenuForm();
            adminMenuForm.ShowDialog();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
