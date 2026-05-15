using AutoMapper;
using SmartSales.Application.DTOs.Customer;
using SmartSales.Domain.Entities;
using SmartSales.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartSales.Application.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CustomerService(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public async Task<CustomerDto> CreateCustomerAsync(CreateCustomerRequestDto requestDto)
        {
            Customer customer = _mapper.Map<CreateCustomerRequestDto, Customer>(requestDto);

            await _unitOfWork.Customers.AddAsync(customer);
            await _unitOfWork.SaveChangesAsync();

            CustomerDto customerDto = _mapper.Map<Customer, CustomerDto>(customer);

            return customerDto;
        }
        public async Task<CustomerDto?> UpdateCustomerAsync(Guid id, UpdateCustomerRequestDto requestDto)
        {
            Customer? customer = await _unitOfWork.Customers.GetByIdAsync(id);
            if (customer == null)
            {
                return null;
            }

            customer.Name = requestDto.Name;
            customer.Phone = requestDto.Phone;
            customer.Address = requestDto.Address;
            
            await _unitOfWork.SaveChangesAsync();

            CustomerDto customerDto = _mapper.Map<Customer, CustomerDto>(customer);

            return customerDto;
        }
    }
}
