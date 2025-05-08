using DotNetCoreWebAPI.Models;
using DotNetCoreWebAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DotNetCoreWebAPI.Controllers
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

        
        // GET: api/Product
        [HttpGet]
        public IActionResult Get()
        {
            var products = _productService.GetProducts();
            return Ok(products);
        }

        // GET api/Product/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var product = _productService.GetProductById(id);
            if (product == null)
            {
                return NotFound($"Product with ID {id} not found.");
            }
            return Ok(product);
        }

        // POST api/Product
        [HttpPost]
        public IActionResult Post([FromBody] Product product)
        {
            if (product == null)
            {
                return BadRequest("Product data is invalid.");
            }

            var result = _productService.CreateProduct(product);
            return CreatedAtAction(nameof(Get), new { id = product.Id }, result);
        }

        // PUT api/Product/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Product product)
        {
            if (product == null)
            {
                return BadRequest("Product data is invalid.");
            }

            var result = _productService.UpdateProduct(id, product);
            if (result == "Product not found")
            {
                return NotFound($"Product with ID {id} not found.");
            }

            return Ok(result);
        }

        // DELETE api/Product/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var result = _productService.DeleteProduct(id);
            if (result == "Product not found")
            {
                return NotFound($"Product with ID {id} not found.");
            }

            return Ok(result);
        }
    }
}
