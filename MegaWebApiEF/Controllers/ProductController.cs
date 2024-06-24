using MegaWebApiEF.Application.Interfaces;
using MegaWebApiEF.Models.RequestDto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MegaWebApiEF.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_productService.GetProducts());
        }
        [HttpGet]
        [Route("{id}")]
        public IActionResult GetProductById(int id)
        {
            return Ok(_productService.GetProductById(id));
        }
        [HttpPost]
        public IActionResult Add([FromBody] AddProductDto addProductDto)
        {
            return Ok(_productService.AddProduct(addProductDto));
        }
        [HttpPut]
        public IActionResult Update([FromBody] UpdateProductDto updateProductDto)
        {
            return Ok(_productService.UpdateProduct(updateProductDto));
        }
    }
}
