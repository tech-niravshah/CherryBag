using CherryBag.Data.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CherryBag.Data
{
    public class OrderRepository
    {
            private CherryBagContext _context;

            public OrderRepository()
            {
                _context = new CherryBagContext();
            }

        public void AddOrder(OrderMaster orderMaster)
        {
            _context.Add(orderMaster);
            _context.SaveChanges();

            //if (orderMaster.Id > 0)
            //{
            //    var orderItems = orderMaster.OrderItems.Select(c => { c.OrderId = orderMaster.Id; return c; }).ToList();
            //    _context.AddRange(orderItems);
            //    //_context.SaveChanges();
            //}

        }
    }
}
