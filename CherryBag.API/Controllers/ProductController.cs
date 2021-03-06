﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CherryBag.Service.Interface;
using CherryBag.Service;
using CherryBag.Service.Model;

namespace CherryBag.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public ActionResult GetProducts()
        {
            var products = _productService.GetProducts();
            return Ok(new { Success = true, data = products });
        }

        [HttpPost]
        public ActionResult AddProduct(ProductModel productModel)
        {
            var result = _productService.AddProduct(productModel);
            return Ok(new { Success = true, data = result });
        }

        [HttpPost]
        [Route("updateproduct")]
        public ActionResult UpdateProduct(ProductModel productModel)
        {
            var result = _productService.UpdateProduct(productModel);
            return Ok(new { Success = true, data = result });
        }
    }
}