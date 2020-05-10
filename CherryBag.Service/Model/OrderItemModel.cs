using System;
using System.Collections.Generic;
using System.Text;

namespace CherryBag.Service.Model
{
    public class OrderItemModel
    {
        public int Id { get; set; }
        public int? ProductId { get; set; }
        public int? Quantity { get; set; }
        public decimal? UnitPrice { get; set; }
        public int? OrderId { get; set; }
        public decimal? Subtotal { get; set; }

    }
}
