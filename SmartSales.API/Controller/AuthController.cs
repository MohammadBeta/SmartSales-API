using Microsoft.AspNetCore.Mvc;

namespace SmartSales.API.Controller;

[ApiController]
[Route("api/[controller]")]

public class AuthController : ControllerBase
{
    [HttpPost("login")]
    public async Task<IActionResult> Login()
    {
        return Ok("Login successful");
    }


    [HttpPost("register")]
    public async Task<IActionResult> Register()
    {
        return Ok("Register successful");
    }
}