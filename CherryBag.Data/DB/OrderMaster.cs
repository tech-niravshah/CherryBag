using System;
using System.Collections.Generic;

namespace CherryBag.Data.DB
{
    public partial class OrderMaster
    {
        public OrderMaster()
        {
            OrderItems = new HashSet<OrderItems>();
        }

        public int Id { get; set; }
        public int? PartyId { get; set; }
        public int? PaymentTypeId { get; set; }
        public decimal? OrderTotal { get; set; }
        public string Note { get; set; }

        public virtual PartyMaster Party { get; set; }
        public virtual PaymentTypeMaster PaymentType { get; set; }
        public virtual ICollection<OrderItems> OrderItems { get; set; }
    }
}
