using Microsoft.AspNetCore.Mvc;
using SmartSales.Application.Services.Auth;

namespace SmartSales.API.Controller;

[ApiController]
[Route("api/[controller]")]

public class AuthController : ControllerBase
{

    private readonly IAuthService _authService;

    public AuthController(IAuthService authService)
    {
        _authService = authService;
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login()
    {
        _authService.LoginAsync(null);
        return Ok("Login successful");
    }


    [HttpPost("register")]
    public async Task<IActionResult> Register()
    {
        _authService.RegisterAsync(null);
        return Ok("Register successful");
    }
}