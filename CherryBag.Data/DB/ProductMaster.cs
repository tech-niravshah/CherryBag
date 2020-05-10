using System;
using System.Collections.Generic;

namespace CherryBag.Data.DB
{
    public partial class ProductMaster
    {
        public ProductMaster()
        {
            OrderItems = new HashSet<OrderItems>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string ItemCode { get; set; }
        public decimal? SalePrice { get; set; }
        public decimal? PurchasePrice { get; set; }
        public int? Quantity { get; set; }
        public string Image { get; set; }

        public virtual ICollection<OrderItems> OrderItems { get; set; }
    }
}
