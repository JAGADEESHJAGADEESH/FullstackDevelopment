using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OrderService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly HttpClient _httpClient;

        public OrderController(IHttpClientFactory httpClientFactory)
        {
            _httpClient = httpClientFactory.CreateClient();
        }

        [HttpGet("products")]
        public async Task<IActionResult> GetProductsFromProductService()
        {
            var response = await _httpClient.GetAsync("https://localhost:44394/api/Product");
            var products = await response.Content.ReadAsStringAsync();
            return Ok(JsonSerializer.Deserialize<List<string>>(products));
        }
    }
}
