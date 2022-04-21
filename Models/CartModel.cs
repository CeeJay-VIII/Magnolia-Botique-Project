﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace ProjectVIII.Models
{
    public class CartModel
    {
        [DisplayName("Product Name")]
        public string productName { get; set; }
        [DisplayName("Price")]
        public double price { get; set; }
        [DisplayName("Quantity")]
        public int quantity { get; set; }

        public double totalAmount { get; set; }


        public double calcTotalAmount()
        {
            return quantity * price;
        }
    }
}