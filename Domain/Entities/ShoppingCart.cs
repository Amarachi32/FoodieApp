﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class ShoppingCart
    {

        public int CartId { get; set; }

        public int TotalItems { get; set; }

        public double TotalPrice { get; set; }

        public double OriginalPrice { get; set; }

        public string UserId { get; set; }

        public string Note { get; set; }
        //public Product Product { get; set; }    
        public User User { get; set; }

        public Order Order { get; set; }

        public string PaymentMethod { get; set; }

        public string Status { get; set; }// checkout -- 1, not check out -- 0

        public List<ShoppingItem> ShoppingItems { get; set; }
    }
}
