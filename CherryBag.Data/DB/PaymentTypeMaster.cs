using System;
using System.Collections.Generic;

namespace CherryBag.Data.DB
{
    public partial class PaymentTypeMaster
    {
        public PaymentTypeMaster()
        {
            OrderMaster = new HashSet<OrderMaster>();
        }

        public int Id { get; set; }
        public string PaymentTypeName { get; set; }

        public virtual ICollection<OrderMaster> OrderMaster { get; set; }
    }
}
