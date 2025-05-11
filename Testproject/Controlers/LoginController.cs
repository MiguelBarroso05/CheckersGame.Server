using Microsoft.AspNetCore.Mvc;
using Testproject.Data;
using Testproject.Models;

namespace Testproject.Controlers;

[ApiController]
[Route("/api/[controller]")]
public class LoginController : ControllerBase
{
    private readonly DataContext _context;


    public LoginController(DataContext context)
    {
        _context = context;
    }

    [HttpPost]
    public IActionResult Post([FromBody] LoginDto dto)
    {
        User? user = _context.Users.FirstOrDefault(u => u.Email == dto.Email);
        if (user is null)
        {
            return NotFound("Credentials not found");
        }

        if (user.Password != dto.Password)
        {
            return BadRequest("Wrong password");
        }

        return Ok();
    }
}