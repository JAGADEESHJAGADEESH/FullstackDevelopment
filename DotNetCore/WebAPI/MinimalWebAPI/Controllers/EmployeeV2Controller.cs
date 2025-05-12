using Asp.Versioning;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MinimalWebAPI.Controllers
{
    [ApiController]
    [Route("api/v2/employees")]
    public class EmployeeV2Controller : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Employees from v2 controller with additional details");
        }
    }
}
