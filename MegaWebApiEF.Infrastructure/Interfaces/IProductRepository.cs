using MegaWebApiEF.Models.Entities;
using MegaWebApiEF.Models.RequestDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaWebApiEF.Infrastructure.Interfaces
{
    public interface IProductRepository
    {
        Task<List<Product>> GetProducts();
        Task<List<Product>> AddProduct(Product product);
    }
}
