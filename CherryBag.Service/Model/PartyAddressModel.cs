using System;
using System.Collections.Generic;
using System.Text;

namespace CherryBag.Service.Model
{
    public class PartyAddressModel
    {
        public int Id { get; set; }
        public int? CityId { get; set; }
        public int? PartyId { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public bool? IsPrimary { get; set; }
    }
}
