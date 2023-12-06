using Microsoft.AspNetCore.Mvc;

namespace WorkflowTestRepository.Interface.Controllers;
[ApiController]
[Route("[controller]")]
public class HomeController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok("Hello World!");
    }
}
