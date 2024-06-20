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
        public async Task<List<Product>> GetProducts()
        {
            var resultList = await _dbContext.Products.ToListAsync();
            return resultList;
        }
        public async Task<List<Product>> AddProduct(Product product)
        {
            await _dbContext.Products.AddAsync(product);
            await _dbContext.SaveChangesAsync();
            return await GetProducts();
        }
    }
}
