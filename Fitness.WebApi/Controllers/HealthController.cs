using Microsoft.AspNetCore.Mvc;

namespace Fitness.WebAPI.Controllers
{
    public class HealthCheckController : ControllerBase
    {
        public HealthCheckController()
        {
        }

        [HttpGet, Route("health")]
        public IActionResult Get()
        {
            return Ok("Online");
        }

    }
}
