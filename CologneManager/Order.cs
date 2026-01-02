using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CologneManager
{
    public class Order
    {
        // 1. Properties
        public int OrderId { get; set; }
        public string CustomerName { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime OrderDate { get; set; }

        // 2. Constructor
        public Order(int id, string custName, string prodName, int qty, decimal price)
        {
            OrderId = id;
            CustomerName = custName;
            ProductName = prodName;
            Quantity = qty;
            TotalPrice = price;
            OrderDate = DateTime.Now;
        }
    }
}