using CherryBag.Service.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace CherryBag.Service.Interface
{
    public interface IPartyService
    {
        public void AddParty(PartyModel partyModel);

        public void AddPartyAddress(PartyAddressModel partyAddressModel);

        public List<PartyModel> GetAllParties();

        public bool UpdateParty(PartyModel partyModel);

        public bool UpdatePartyAddress(PartyAddressModel partyAddressModel);
    }
}
