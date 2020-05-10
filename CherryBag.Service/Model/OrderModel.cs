using CherryBag.Data.DB;
using System;
using System.Collections.Generic;
using System.Text;
using CherryBag.Service.Model;

namespace CherryBag.Service.Model
{
    public class OrderModel
    {
        public int Id { get; set; }
        public int? PartyId { get; set; }
        public int? PaymentTypeId { get; set; }
        public decimal? OrderTotal { get; set; }
        public string Note { get; set; }

        public List<OrderItemModel> OrderItems { get; set; }
    }
}
