using iTextSharp.text.pdf;
using iTextSharp.text;
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
            string connStr = "server=127.0.0.1; database=siomai; uid=root; pwd=axell;";
            string query = "SELECT id, item_name, quantity, total_price, transaction_date FROM transactions";

            DataTable reportTable = new DataTable();

            using (var connection = new MySql.Data.MySqlClient.MySqlConnection(connStr))
            {
                try
                {
                    MySql.Data.MySqlClient.MySqlDataAdapter adapter = new MySql.Data.MySqlClient.MySqlDataAdapter(query, connection);
                    adapter.Fill(reportTable);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error retrieving data: " + ex.Message);
                    return;
                }
            }

            if (reportTable.Rows.Count == 0)
            {
                MessageBox.Show("No transactions found to generate report.");
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "PDF files (*.pdf)|*.pdf";
                sfd.FileName = "TransactionReport.pdf";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        Document document = new Document(PageSize.A4, 25, 25, 30, 30);
                        PdfWriter.GetInstance(document, new FileStream(sfd.FileName, FileMode.Create));
                        document.Open();

                        Paragraph title = new Paragraph("Transaction Report", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16));
                        title.Alignment = Element.ALIGN_CENTER;
                        title.SpacingAfter = 20f;
                        document.Add(title);

                        PdfPTable pdfTable = new PdfPTable(reportTable.Columns.Count);
                        pdfTable.WidthPercentage = 100;

                        // Add table headers
                        foreach (DataColumn column in reportTable.Columns)
                        {
                            PdfPCell headerCell = new PdfPCell(new Phrase(column.ColumnName, FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12)));
                            headerCell.BackgroundColor = BaseColor.LIGHT_GRAY;
                            pdfTable.AddCell(headerCell);
                        }

                        // Add rows
                        foreach (DataRow row in reportTable.Rows)
                        {
                            foreach (var item in row.ItemArray)
                            {
                                pdfTable.AddCell(item.ToString());
                            }
                        }

                        document.Add(pdfTable);
                        document.Close();

                        MessageBox.Show("PDF report saved to:\n" + sfd.FileName);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error generating PDF: " + ex.Message);
                    }
                }
            }
        }
    }
}
     
