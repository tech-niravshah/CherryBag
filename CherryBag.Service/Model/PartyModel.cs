using System;
using System.Collections.Generic;
using System.Text;

namespace CherryBag.Service.Model
{
    public class PartyModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? PartyTypeId { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public PartyAddressModel PartyAddressModel { get; set; }

        public List<PartyAddressModel> UserAddress { get; set; }
    }
}
