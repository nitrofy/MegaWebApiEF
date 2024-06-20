using MegaWebApiEF.Models.Entities;
using MegaWebApiEF.Models.RequestDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaWebApiEF.Application.Interfaces
{
    public interface IProductService
    {
        Task<List<Product>> GetProducts();
        Task<List<Product>> AddProduct(AddProductDto addProduct);
    }
}
