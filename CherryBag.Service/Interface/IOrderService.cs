using CherryBag.Data.DB;
using System;
using System.Collections.Generic;
using System.Text;
using CherryBag.Service.Model;

namespace CherryBag.Service.Interface
{
    public interface IOrderService
    {
        public void AddOrder(OrderModel orderMaster);

        public void AddOrderWithParty(OrderPartyModel orderPartyModel);
    }
}
