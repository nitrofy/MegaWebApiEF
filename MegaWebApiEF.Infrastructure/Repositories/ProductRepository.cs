using MegaWebApiEF.Infrastructure.DBAccess;
using MegaWebApiEF.Infrastructure.Interfaces;
using MegaWebApiEF.Models.Entities;
using MegaWebApiEF.Models.RequestDto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaWebApiEF.Infrastructure.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly MegaAppEFDBontext _dbContext;
        public ProductRepository(MegaAppEFDBontext dbContext)
        {
            _dbContext = dbContext;
        }
        public List<Product> GetProducts()
        {
            var resultList = _dbContext.Products.ToList();
            return resultList;
        }
        public List<Product> GetProductById(int id)
        {
            var resultList = _dbContext.Products.Where(p => p.Id == id).ToList();
            return resultList;
        }
        public bool AddProduct(List<Product> products)
        {
            int rowsaffected = 0;
            foreach (var item in products)
            {                
                _dbContext.Products.Add(item);
            }
            rowsaffected = _dbContext.SaveChanges();
            return rowsaffected>0;
        }
        public bool UpdateProduct(Product product)
        {
            int rowsaffected = 0;
            var existingProduct = _dbContext.Products.Find(product.Id);
            if (existingProduct != null)
            {
                //existingProduct = product;
                _dbContext.Products.Entry(existingProduct).CurrentValues.SetValues(product);
                rowsaffected = _dbContext.SaveChanges();
            }
            return rowsaffected > 0;
        }
        public bool DeleteProduct(int productId)
        {
            int rowsaffected = 0;
            Product existingProduct = _dbContext.Products.Where(p => p.Id == productId).FirstOrDefault();
            if (existingProduct != null)
            {
                _dbContext.Products.Remove(existingProduct);
                rowsaffected = _dbContext.SaveChanges();
            }
            return rowsaffected > 0;
        }
    }
}
