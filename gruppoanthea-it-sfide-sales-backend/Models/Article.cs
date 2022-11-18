using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace gruppoanthea_it_sfide_sales_backend.Models
{
    public class Article
    {
        public Guid id { get; set; }
        public string name { get; set; }
        public string url { get; set; }
        public double price { get; set; }
        public bool isImported { get; set; }
        public int basicSalesTax { get; set; }
    }
}