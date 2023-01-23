using BlazorApp1.Server.Services.ProductService;
using BlazorApp1.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorApp1.Server.Controllers
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
        public async Task<ActionResult<List<Product>>> GetAllProducts() 
        {
            return Ok(await _productService.GetAllProducts());
        }
        [HttpGet("{categoryUrl}")]
        public async Task<ActionResult<List<Product>>> GetProductsByCategory(string categoryUrl)
        {
            return Ok(await _productService.GetProductsByCategory(categoryUrl));
        }
    }
}
