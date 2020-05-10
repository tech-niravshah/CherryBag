using System;
using System.Collections.Generic;

namespace CherryBag.Data.DB
{
    public partial class UserAddress
    {
        public int Id { get; set; }
        public int? CityId { get; set; }
        public int? PartyId { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public bool? IsPrimary { get; set; }

        public virtual CityMaster City { get; set; }
        public virtual PartyMaster Party { get; set; }
    }
}
