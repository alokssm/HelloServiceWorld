using Microsoft.AspNetCore.Mvc;

namespace HelloService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HelloController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get() =>
            Ok(new { message = "Hello from .NET 8 Microservice!" });

        [HttpGet("{name}")]
        public IActionResult Greet(string name) =>
            Ok(new { message = $"Hello {name}, welcome to .NET 8 Microservice!" });
    }
}
