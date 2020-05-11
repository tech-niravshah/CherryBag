using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CherryBag.Service.Interface;
using CherryBag.Service;
using CherryBag.Service.Model;
using System.Net;
using CherryBag.Service.Model;

namespace CherryBag.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private IOrderService _orderService;
        private IPartyService _partyService;

        public OrderController(IOrderService orderService, IPartyService partyService)
        {
            _orderService = orderService;
            _partyService = partyService;
        }

        [HttpPost]
        [Route("AddOrder")]
        public ActionResult AddOrder(OrderModel orderModel)
        {
            try
            {
                _orderService.AddOrder(orderModel);
                return Ok(new { Success = true, data = "Success" });
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.InnerException);
            }
        }

        [HttpPost]
        [Route("AddOrderWithParty")]
        public ActionResult AddOrderWithParty(OrderPartyModel orderPartyModel)
        {
            try
            {
                _orderService.AddOrderWithParty(orderPartyModel);
                return Ok(new { Success = true, data = "Success" });
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.InnerException);
            }
        }
    }
}