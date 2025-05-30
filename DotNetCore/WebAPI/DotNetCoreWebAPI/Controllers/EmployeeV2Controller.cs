﻿using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DotNetCoreWebAPI.Controllers
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
