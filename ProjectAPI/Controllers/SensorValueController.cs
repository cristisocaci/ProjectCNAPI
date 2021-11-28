using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SensorValueController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get([FromQuery] int value)
        {
            return Ok(value);
        }
    }
}
