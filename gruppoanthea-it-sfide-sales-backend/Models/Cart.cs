using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace gruppoanthea_it_sfide_sales_backend.Models
{
    public class Cart
    {
        public Article article { get; set; }
        public int quantity { get; set; }
        public double salesTaxes { get; set; }
        public double price { get; set; }
    }
}