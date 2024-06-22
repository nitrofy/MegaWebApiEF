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
        public List<Product> AddProduct(Product product)
        {
            _dbContext.Products.Add(product);
            _dbContext.SaveChanges();
            return GetProducts();
        }
    }
}
