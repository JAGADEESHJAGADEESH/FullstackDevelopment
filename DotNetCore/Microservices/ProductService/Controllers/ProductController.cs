using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProductService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private static readonly List<string> Products = new() { "Product1", "Product2", "Product3" };

        [HttpGet]
        public IActionResult GetProducts()
        {
            return Ok(Products);
        }

        [HttpPost]
        public IActionResult AddProduct([FromBody] string product)
        {
            Products.Add(product);
            return Created("", product);
        }
    }
}
