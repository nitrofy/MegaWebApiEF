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
        public List<Product> GetProductById(int id)
        {
            var resultList = _productRepository.GetProductById(id);
            return resultList;
        }
        public List<Product> AddProduct(AddProductDto addProductDto)
        {
            var addProduct = new Product
            {
                Name = addProductDto.Name,
                Tags = addProductDto.Tags,
                Description = addProductDto.Description
            };
            return _productRepository.AddProduct(addProduct);
        }
        public List<Product> UpdateProduct(UpdateProductDto updateProductDto)
        {
            var updateProduct = new Product
            {
                Id = updateProductDto.Id,
                Name = updateProductDto.Name,
                Tags = updateProductDto.Tags,
                Description = updateProductDto.Description
            };
            return _productRepository.UpdateProduct(updateProduct);
        }
    }
}
