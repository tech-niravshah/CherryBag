using System;
using System.Collections.Generic;

namespace CherryBag.Data.DB
{
    public partial class OrderItems
    {
        public int Id { get; set; }
        public int? ProductId { get; set; }
        public int? Quantity { get; set; }
        public decimal? UnitPrice { get; set; }
        public int? OrderId { get; set; }
        public decimal? Subtotal { get; set; }

        public virtual OrderMaster Order { get; set; }
        public virtual ProductMaster Product { get; set; }
    }
}
