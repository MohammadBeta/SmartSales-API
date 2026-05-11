using AutoMapper;
using SmartSales.Application.DTOs.Auth;
using SmartSales.Application.Interfaces;
using SmartSales.Domain.Entities;
using SmartSales.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.JavaScript;
using System.Text;
using System.Threading.Tasks;

namespace SmartSales.Application.Services.Auth
{
    class AuthService : IAuthService
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IJwtTokenGenerator _jwtTokenGenerator;

        public AuthService(IUnitOfWork unitOfWork, IJwtTokenGenerator jwtTokenGenerator, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _jwtTokenGenerator = jwtTokenGenerator;
            _mapper = mapper;
        }

        public async Task<LoginResponseDto> LoginAsync(LoginRequestDto loginRequestDto)
        {
            User? user = await _unitOfWork.Users.GetUserByEmailAsync(loginRequestDto.Email);
            if (user == null || user.Password != loginRequestDto.Password)
            {
                throw new UnauthorizedAccessException("Invalid email or password.");
            }
            LoginResponseDto loginResponse = _mapper.Map<User, LoginResponseDto>(user);
            string token = _jwtTokenGenerator.GenerateToken(user.Id, user.Email, user.FirstName, user.LastName);
            loginResponse.Token = token;
            return loginResponse;
        }

        public async Task<RegisterResponseDto> RegisterAsync(RegisterRequestDto registerRequestDto)
        {
            User? user = await _unitOfWork.Users.GetUserByEmailAsync(registerRequestDto.Email);
            if (user != null)
            {
                throw new Exception("Email already in use.");
            }

            User newUser = _mapper.Map<RegisterRequestDto, User>(registerRequestDto);
            await _unitOfWork.Users.AddAsync(newUser);
            await _unitOfWork.SaveChangesAsync();
            string token = _jwtTokenGenerator.GenerateToken(newUser.Id, newUser.Email, newUser.FirstName, newUser.LastName);
            RegisterResponseDto responseDto = _mapper.Map<User, RegisterResponseDto>(newUser);
            responseDto.Token = token;
            return responseDto;
        }
    }
}
