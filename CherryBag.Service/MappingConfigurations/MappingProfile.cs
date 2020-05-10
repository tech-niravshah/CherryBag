using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using CherryBag.Data.DB;
using CherryBag.Service.Model;

namespace CherryBag.Service.MappingConfigurations
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<PartyMaster, PartyModel>();
            CreateMap<PartyModel, PartyMaster>();

            CreateMap<PartyAddressModel, UserAddress>();
            CreateMap<UserAddress, PartyAddressModel>();

            CreateMap<OrderMaster, OrderModel>();
            CreateMap<OrderModel, OrderMaster>();

            CreateMap<OrderItems, OrderItemModel>();
            CreateMap<OrderItemModel, OrderItems>();

            CreateMap<ProductModel, ProductMaster>();
            CreateMap<ProductMaster, ProductModel>();


        }
    }
}
