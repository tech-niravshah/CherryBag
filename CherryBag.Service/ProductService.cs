using AutoMapper;
using CherryBag.Data;
using CherryBag.Service.Model;
using System;
using System.Collections.Generic;
using System.Text;
using CherryBag.Service.Interface;
using CherryBag.Data.DB;

namespace CherryBag.Service
{
    public class ProductService : IProductService
    {
        private readonly IMapper _mapper;
        private readonly ProductRepository _repo;
        public ProductService(IMapper mapper)
        {
            _mapper = mapper;
            _repo = new ProductRepository();
        }


        public List<ProductModel> GetProducts()
        {
            var products = _repo.GetProducts();
            var productList = _mapper.Map<List<ProductModel>>(products);
            return productList;
        }

        public bool AddProduct(ProductModel productModel)
        {
            var product = _mapper.Map<ProductMaster>(productModel);
            return _repo.AddProduct(product);
        }

        public bool UpdateProduct(ProductModel productModel)
        {
            var product = _mapper.Map<ProductMaster>(productModel);
            return _repo.UpdateProduct(product);
        }
    }
}
