using Application.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PingController : ControllerBase
    {
        private readonly IPingService _pingService;

        public PingController(IPingService pingService)
        {
            _pingService = pingService;
        }

        [HttpGet("/getPing")]
        public async Task<IActionResult> GetPing()
        {
            var ping = await _pingService.GetPingAsync();
            return Ok(ping);
        }
    }
}
