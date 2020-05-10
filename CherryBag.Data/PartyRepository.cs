using System;
using System.Collections.Generic;
using System.Text;
using CherryBag.Data.DB;

namespace CherryBag.Data
{
    public class PartyRepository
    {
        private CherryBagContext _context;

        public PartyRepository()
        {
            _context = new CherryBagContext();
        }

        public void AddParty(PartyMaster partyMaster)
        {
            _context.Add(partyMaster);
            _context.SaveChanges();
        }

        public void AddPartyAddress(UserAddress userAddress)
        {
            _context.Add(userAddress);
            _context.SaveChanges();
        }
    }
}
