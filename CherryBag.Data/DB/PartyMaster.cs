using System;
using System.Collections.Generic;

namespace CherryBag.Data.DB
{
    public partial class PartyMaster
    {
        public PartyMaster()
        {
            OrderMaster = new HashSet<OrderMaster>();
            UserAddress = new HashSet<UserAddress>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? PartyTypeId { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public virtual PartyTypeMaster PartyType { get; set; }
        public virtual ICollection<OrderMaster> OrderMaster { get; set; }
        public virtual ICollection<UserAddress> UserAddress { get; set; }
    }
}
