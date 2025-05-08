using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Cmp;

namespace siomai
{
    public partial class orderForm : Form
    {
        private List<Order> orders = new List<Order>();
        private int nextOrderID = 1;
        private string todayDate = DateTime.Now.ToString("yyyy-MM-dd");
        private List<MenuItem> availableMenuItems = new List<MenuItem>
        {
            new MenuItem("Siomai Rice", 50, 1),
            new MenuItem("Beef Siomai", 45, 1),
            new MenuItem("Japanese Siomai", 55, 1),
            new MenuItem("Ratmai", 60.00m, 1)
        };

        private List<MenuItem> selectedOrderItems = new List<MenuItem>();

        public orderForm()
        {
            InitializeComponent();
            LoadMenuItems();
            RefreshGrid();
            UpdateTotalPriceDisplay();
        }

        public void LoadMenuItems()
        {
            cmbMenuItems.DataSource = MenuManager.MenuItems;  // Get menu items from MenuManager
            cmbMenuItems.DisplayMember = "Name";  // Display the Name property in the ComboBox
        }




        private void RefreshOrderItemsList()
        {
            lstOrderItems.DataSource = null;
            lstOrderItems.DataSource = selectedOrderItems;
        }





        private void RefreshGrid()
        {
            dgvOrders.DataSource = null;
            dgvOrders.DataSource = selectedOrderItems.Select(item => new
            {
                Item = item.Name,
                Quantity = item.Quantity,
                Price = item.Price,
                Subtotal = item.Price * item.Quantity
            }).ToList();
        }

        private void UpdateTotalPriceDisplay()
        {
            lblTotalPrice.Text = $"Total: ₱{selectedOrderItems.Sum(item => item.Price * item.Quantity):0.00}";
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {

            if (cmbMenuItems.SelectedItem != null)
            {
                MenuItem selectedItem = (MenuItem)cmbMenuItems.SelectedItem;
                int quantity = (int)numQuantity.Value;

                if (quantity < 1)
                {
                    MessageBox.Show("Please enter a valid quantity.");
                    return;
                }

                // Add item to order list
                MenuItem orderItem = new MenuItem(selectedItem.Name, selectedItem.Price, quantity);
                selectedOrderItems.Add(orderItem);

                // Update ListBox
                RefreshOrderItemsList();

                // Update DataGridView instantly
                RefreshGrid();

                // Update total price display
                UpdateTotalPriceDisplay();
            }
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            if (selectedOrderItems.Count == 0)
            {
                MessageBox.Show("No items in the order. Please add items before placing an order.");
                return;
            }

            string connStr = "server=127.0.0.1; database=siomai; uid=root; pwd=axell;";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    foreach (var item in selectedOrderItems)
                    {
                        string query = "INSERT INTO transactions (item_name, quantity, total_price) VALUES (@item, @qty, @price)";
                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@item", item.Name);
                            cmd.Parameters.AddWithValue("@qty", item.Quantity);
                            cmd.Parameters.AddWithValue("@price", item.Price * item.Quantity);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Order placed!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to save order: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // Clear the order list after placing order
            selectedOrderItems.Clear();
            RefreshOrderItemsList();
            RefreshGrid();
            UpdateTotalPriceDisplay();
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (lstOrderItems.SelectedItem != null)
            {
                MenuItem selectedItem = (MenuItem)lstOrderItems.SelectedItem;

                // Ask user for new quantity
                int newQuantity = (int)numQuantity.Value;
                if (newQuantity < 1)
                {
                    MessageBox.Show("Please enter a valid quantity.");
                    return;
                }

                // Update quantity
                selectedItem.Quantity = newQuantity;

                // Refresh the list and grid
                RefreshOrderItemsList();
                RefreshGrid();
                UpdateTotalPriceDisplay();
            }
            else
            {
                MessageBox.Show("Please select an item to update.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstOrderItems.SelectedItem != null)
            {
                MenuItem selectedItem = (MenuItem)lstOrderItems.SelectedItem;

                // Remove item
                selectedOrderItems.Remove(selectedItem);

                // Refresh the list and grid
                RefreshOrderItemsList();
                RefreshGrid();
                UpdateTotalPriceDisplay();
            }
            else
            {
                MessageBox.Show("Please select an item to delete.");
            }
        }
    }

}

