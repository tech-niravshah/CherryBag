using System;
using System.Collections.Generic;
using System.Text;

namespace CherryBag.Service.Model
{
    public class ProductModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ItemCode { get; set; }
        public decimal? SalePrice { get; set; }
        public decimal? PurchasePrice { get; set; }
        public int? Quantity { get; set; }
        public string Image { get; set; }
    }
}
