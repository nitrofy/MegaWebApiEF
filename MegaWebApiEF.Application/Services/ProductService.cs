using MegaWebApiEF.Application.Interfaces;
using MegaWebApiEF.Infrastructure.Interfaces;
using MegaWebApiEF.Models.Entities;
using MegaWebApiEF.Models.RequestDto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaWebApiEF.Application.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public List<Product> GetProducts()
        {
            var resultList = _productRepository.GetProducts();
            return resultList;
        }
        public List<Product> AddProduct(AddProductDto addProduct)
        {
            var newProduct = new Product
            {
                Name = addProduct.Name,
                Tags = addProduct.Tags,
                Description = addProduct.Description
            };
            return _productRepository.AddProduct(newProduct);
        }
    }
}
