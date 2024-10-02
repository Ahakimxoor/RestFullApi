/*using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Linq;

namespace HeaderDemo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HeadersController : ControllerBase
    {
        private readonly ILogger<HeadersController> _logger;

        public HeadersController(ILogger<HeadersController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult GetHeaders()
        {
            // Read a specific header
            if (Request.Headers.TryGetValue("Custom-Header", out var headerValue))
            {
                _logger.LogInformation($"Custom-Header: {headerValue}");
            }

            // Read all headers
            var allHeaders = Request.Headers.ToDictionary(h => h.Key, h => h.Value.ToString());

            return Ok(allHeaders);
        }

        [HttpPost]
        public IActionResult SetHeaders()
        {
            // Set headers in the response
            Response.Headers.Add("Custom-Response-Header", "MyCustomValue");
            return Ok(new { Message = "Headers set in the response" });
        }
    }
}*/
