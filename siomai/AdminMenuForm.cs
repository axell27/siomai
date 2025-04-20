using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace siomai
{
    public partial class AdminMenuForm : Form
    {
        private List<MenuItem> menuItems = new List<MenuItem>();

        public AdminMenuForm()
        {
            InitializeComponent();
            LoadMenuItems();  // Load existing menu items when the form is initialized
        }

        private void LoadMenuItems()
        {
            // Clear any existing items
            lstMenuItems.Items.Clear();

            // Add each menu item to the ListBox
            foreach (var item in MenuManager.MenuItems)
            {
                lstMenuItems.Items.Add($"{item.Name} - ₱{item.Price:F2}");
            }
        }


        private void btnAddItem_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string priceText = txtPrice.Text.Trim();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(priceText))
            {
                MessageBox.Show("Please fill out both name and price fields.");
                return;
            }

            if (!decimal.TryParse(priceText, out decimal price))
            {
                MessageBox.Show("Price must be a valid number.");
                return;
            }

            // Add new item to the MenuManager's list
            MenuItem newItem = new MenuItem(name, price, 0); // Quantity is not used here
            MenuManager.AddMenuItem(newItem);

            // Refresh the ListBox in AdminMenuForm to show the new item
            LoadMenuItems();

            // Clear the input fields
            txtName.Clear();
            txtPrice.Clear();
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            // Check if an item is selected in the ListView
            if (lstMenuItems.SelectedItems.Count > 0)
            {
                // Get the selected menu item text
                string selectedItemText = lstMenuItems.SelectedItems[0].Text;

                // Extract the name of the menu item (the part before " - ₱")
                string itemName = selectedItemText.Split(' ')[0];

                // Find the corresponding MenuItem in the MenuManager's list
                MenuItem itemToRemove = MenuManager.MenuItems.FirstOrDefault(item => item.Name == itemName);

                if (itemToRemove != null)
                {
                    // Remove the item from the MenuManager list
                    MenuManager.RemoveMenuItem(itemToRemove);

                    // Refresh the ListView to reflect the change
                    LoadMenuItems();  // This will update the ListView

                    MessageBox.Show("Item deleted successfully.");
                }
                else
                {
                    MessageBox.Show("Item not found.");
                }
            }
            else
            {
                MessageBox.Show("Please select an item to delete.");
            }
        }

    }

}
