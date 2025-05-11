using Microsoft.AspNetCore.Mvc;
using Testproject.Models;
using Testproject.Services;

namespace Testproject.Controlers;

[ApiController]
[Route("api/[controller]")]
public class RegisterController : ControllerBase
{
    [HttpPost]
    public IActionResult Post([FromServices] IRegisterService registerService, [FromBody] User user)
    {
        registerService.Register(user);
        return Ok("lets see");
    }
}