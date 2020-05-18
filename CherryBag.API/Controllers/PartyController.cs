using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CherryBag.Service;
using CherryBag.Service.Model;
using CherryBag.Service.Interface;
using System.Net;

namespace CherryBag.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PartyController : ControllerBase
    {
        private IPartyService _partyService;
        public PartyController(IPartyService partyService)
        {
            _partyService = partyService;
        }

        [HttpPost]
        [Route("addparty")]
        public ActionResult AddParty(PartyModel partyModel)
        {
            try
            {
                _partyService.AddParty(partyModel);
                return Ok(new { Success = true, data = "Success" });
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, new { Success = false, data = "Internal Server Error", Message = ex.Message });
            }
        }

        [HttpPost]
        [Route("updateparty")]
        public ActionResult UpdateParty(PartyModel partyModel)
        {
            try
            {
                _partyService.UpdateParty(partyModel);
                return Ok(new { Success = true, data = "Success" });
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, new { Success = false, data = "Internal Server Error", Message = ex.Message });
            }
        }

        [HttpPost]
        [Route("addpartyaddress")]
        public ActionResult AddPartyAddress(PartyAddressModel partyAddressModel)
        {
            try
            {
                _partyService.AddPartyAddress(partyAddressModel);
                return Ok(new { Success = true, data = "Success" });
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, new { Success = false, data = "Internal Server Error", Message = ex.Message });
            }
        }

        [HttpGet]
        [Route("Getallparties")]
        public ActionResult GetAllParties()
        {
            var partyList = _partyService.GetAllParties();
            return Ok(new { Success = true, data = partyList });
        }

        [HttpPost]
        [Route("updatepartyaddress")]
        public ActionResult UpdatePartyAddress(PartyAddressModel partyAddressModel)
        {
            try
            {
                _partyService.UpdatePartyAddress(partyAddressModel);
                return Ok(new { Success = true, data = "Success" });
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, new { Success = false, data = "Internal Server Error", Message = ex.Message });
            }
        }
    }
}