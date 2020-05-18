using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CherryBag.Data.DB;

namespace CherryBag.Data
{
    public class ProductRepository
    {
        private CherryBagContext _context;

        public ProductRepository()
        {
            _context = new CherryBagContext();
        }

        public List<ProductMaster> GetProducts()
        {
            return _context.ProductMaster.ToList();
        }

        public bool AddProduct(ProductMaster productMaster)
        {
            try
            {
                _context.ProductMaster.Add(productMaster);
                _context.SaveChanges();
                return true;
            }

            catch(Exception exception)
            {
                return false;
            }
        }

        public bool UpdateProduct(ProductMaster productMaster)
        {
            try
            {
                _context.ProductMaster.Update(productMaster);
                _context.SaveChanges();
                return true;
            }

            catch (Exception exception)
            {
                return false;
            }
        }
    }
}
