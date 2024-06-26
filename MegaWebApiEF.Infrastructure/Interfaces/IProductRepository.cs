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
        List<Product> GetProducts();
        List<Product> GetProductById(int id);
        bool AddProduct(List<Product> products);
        bool UpdateProduct(Product product);
        bool DeleteProduct(int productId);
    }
}
