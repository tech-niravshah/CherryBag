using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using CherryBag.Data;
using CherryBag.Data.DB;
using CherryBag.Service.Interface;
using CherryBag.Service.Model;

namespace CherryBag.Service
{
    public class OrderService : IOrderService
    {
        private readonly IMapper _mapper;
        private readonly OrderRepository _repo;

        public OrderService(IMapper mapper)
        {
            _mapper = mapper;
            _repo = new OrderRepository();
        }
        public void AddOrder(OrderModel orderModel)
        {
            var order = _mapper.Map<OrderMaster>(orderModel);
            _repo.AddOrder(order);
        }
    }
}
