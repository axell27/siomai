using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace siomai
{
    public class Order
    {
        public int OrderID { get; set; }
        public List<MenuItem> Items { get; set; }
        public decimal TotalPrice { get; set; }
        public string OrderDate { get; set; }

        public Order(int orderId, List<MenuItem> items, string orderDate)
        {
            OrderID = orderId;
            Items = items;
            TotalPrice = items.Sum(item => item.Price * item.Quantity);
            OrderDate = orderDate;
        }
    }


}
