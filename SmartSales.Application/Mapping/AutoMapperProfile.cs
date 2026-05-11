using AutoMapper;
using SmartSales.Application.DTOs.Auth;
using SmartSales.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartSales.Application.Mapping
{
    class AutoMapperProfile : Profile
    {

        public AutoMapperProfile()
        {
            CreateMap<RegisterRequestDto, User>();
            CreateMap<User, RegisterResponseDto>();
            CreateMap<User, LoginResponseDto>();
        }
    }
}
