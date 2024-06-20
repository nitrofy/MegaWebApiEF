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
        public async Task<IActionResult> Get()
        {
            return Ok(await _productService.GetProducts());
        }
        [HttpPost]
        public async Task<IActionResult> Add([FromBody] AddProductDto addProductDTO)
        {
            return Ok(await _productService.AddProduct(addProductDTO));
        }
    }
}
