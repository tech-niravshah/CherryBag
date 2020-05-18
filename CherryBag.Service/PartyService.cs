using System;
using System.Collections.Generic;
using System.Text;
using CherryBag.Service.Model;
using AutoMapper;
using CherryBag.Data.DB;
using CherryBag.Data;
using CherryBag.Service.Interface;

namespace CherryBag.Service
{
    public class PartyService : IPartyService
    {
        private readonly IMapper _mapper;
        private readonly PartyRepository _repo;
        public PartyService(IMapper mapper)
        {
            _mapper = mapper;
            _repo = new PartyRepository();
        }
        public void AddParty(PartyModel partyModel)
        {
            var party = _mapper.Map<PartyMaster>(partyModel);
            _repo.AddParty(party);
        }

        public void AddPartyAddress(PartyAddressModel partyAddressModel)
        {
            var partyAddress = _mapper.Map<UserAddress>(partyAddressModel);
            _repo.AddPartyAddress(partyAddress);
        }

        public List<PartyModel> GetAllParties()
        {
            var partyList = _repo.GetAllParties();
            var parties = _mapper.Map<List<PartyModel>>(partyList);
            return parties;
        }
    }
}
