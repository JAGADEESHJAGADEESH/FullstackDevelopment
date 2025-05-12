using Asp.Versioning;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MinimalWebAPI.Controllers
{
    [ApiController]
    [Route("api/v1/employees")]
    public class EmployeeV1Controller : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Employees from v1 controller");
        }
    }
}
