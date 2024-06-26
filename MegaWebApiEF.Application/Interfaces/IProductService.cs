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
        List<Product> GetProducts();
        List<Product> GetProductById(int id);
        bool AddProduct(List<AddProductDto> addProduct);
        bool UpdateProduct(UpdateProductDto updateProduct);
        bool DeleteProduct(int productId);
    }
}
