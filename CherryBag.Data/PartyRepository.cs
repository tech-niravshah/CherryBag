using System;
using System.Collections.Generic;
using System.Text;
using CherryBag.Data.DB;
using System.Linq;

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

        public bool UpdateParty(PartyMaster partyMaster)
        {
            try
            {
                _context.Update(partyMaster);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public void AddPartyAddress(UserAddress userAddress)
        {
            _context.Add(userAddress);
            _context.SaveChanges();
        }

        public List<PartyMaster> GetAllParties()
        {
            var partyList = (from party in _context.PartyMaster
                             join address in _context.UserAddress on party.Id equals address.PartyId into pa
                             from address in pa.DefaultIfEmpty()
                             select new PartyMaster()
                             {
                                 Id = party.Id,
                                 Email = party.Email,
                                 Name = party.Name,
                                 PartyType = party.PartyType,
                                 PartyTypeId = party.PartyTypeId,
                                 PhoneNumber = party.PhoneNumber,
                                 UserAddress = party.UserAddress
                             }).ToList();

            return partyList;

        }

        public bool UpdatePartyAddress(UserAddress partyAddressModel)
        {
            try
            {
                _context.Update(partyAddressModel);
                _context.SaveChanges();
                return true;
            }

            catch(Exception exception)
            {
                return false;
            }
        }
    }
}
