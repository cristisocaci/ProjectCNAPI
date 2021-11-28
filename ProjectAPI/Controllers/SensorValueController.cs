using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using ProjectAPI.Hubs;
using System.Threading.Tasks;

namespace ProjectAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SensorValueController : ControllerBase
    {
        private readonly IHubContext<ValueHub> _valueHub;

        public SensorValueController(IHubContext<ValueHub> valueHub)
        {
            _valueHub = valueHub;
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] int value)
        {
            await _valueHub.Clients.All.SendAsync("ReceiveMessage", value);
            return Ok();
        }
    }
}
