using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace siomai
{
    public static class MenuManager
    {
        // Static list to hold all menu items
        public static List<MenuItem> MenuItems { get; set; } = new List<MenuItem>
        {
            new MenuItem("Siomai Rice", 50, 1),
            new MenuItem("Beef Siomai", 45, 1),
            new MenuItem("Japanese Siomai", 55, 1),
            new MenuItem("Ratmai", 60.00m, 1)
        };

        // Method to add new menu items
        public static void AddMenuItem(MenuItem item)
        {
            MenuItems.Add(item);
        }
        public static void RemoveMenuItem(MenuItem item)
        {
            MenuItems.Remove(item); // Remove the item from the list
        }

    }
}
