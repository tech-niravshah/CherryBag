using System;
using System.Collections.Generic;
using System.Text;

namespace CherryBag.Service.Model
{
    public class OrderPartyModel
    {
        public PartyModel PartyModel { get; set; }

        public OrderModel OrderModel { get; set; }
    }
}
