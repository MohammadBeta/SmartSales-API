
using Microsoft.AspNetCore.Mvc;
using SmartSales.Application.DTOs.Auth;
using SmartSales.Application.Services.Auth;
namespace SmartSale.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login(LoginRequestDto loginRequestDto)
        {
            LoginResponseDto loginResponseDto = await _authService.LoginAsync(loginRequestDto);

            return Ok(loginResponseDto);
        }
        [HttpPost]
        [Route("register")]
        public async Task<IActionResult> Register(RegisterRequestDto registerRequestDto)
        {
            RegisterResponseDto registerResponseDto = await _authService.RegisterAsync(registerRequestDto);
            
            return Ok(registerResponseDto);
        }
    }
}
