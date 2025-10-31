using AutoMapper;
using SmartSales.Application.DTOs.Auth;
using SmartSales.Domain.Interface;

namespace SmartSales.Application.Services.Auth;

public class AuthService : IAuthService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;


    public AuthService(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public Task<AuthResponseDto> LoginAsync(LoginRequestDto loginRequest)
    {
        throw new NotImplementedException();
    }

    public Task<AuthResponseDto> RegisterAsync(RegisterRequestDto registerRequest)
    {
        throw new NotImplementedException();
    }
}