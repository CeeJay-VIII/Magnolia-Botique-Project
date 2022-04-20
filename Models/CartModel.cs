using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectVIII.Models
{
    public class CartModel
    {
        public string productName { get; set; }
        public double price { get; set; }
        public int quantity { get; set; }
        public double totalAmount { get; set; }


        public double calcTotalAmount()
        {
            return quantity * price;
        }
    }
}