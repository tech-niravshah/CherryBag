﻿using System;
using System.Collections.Generic;
using System.Text;
using CherryBag.Service.Model;

namespace CherryBag.Service.Interface
{
    public interface IProductService
    {
        public List<ProductModel> GetProducts();
        public bool AddProduct(ProductModel productModel);

        public bool UpdateProduct(ProductModel productModel);

    }
}
