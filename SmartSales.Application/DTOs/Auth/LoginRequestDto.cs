namespace SmartSales.Application.DTOs.Auth;

public record LoginRequestDto
{
    public string Email { get; init; }
    public string Password { get; init; }
}