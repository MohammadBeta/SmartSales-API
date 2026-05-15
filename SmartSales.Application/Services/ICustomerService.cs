using SmartSales.Application.DTOs.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartSales.Application.Services
{
    public interface ICustomerService
    {
        Task<CustomerDto> CreateCustomerAsync(CreateCustomerRequestDto requestDto);
        Task<CustomerDto?> UpdateCustomerAsync(Guid id, UpdateCustomerRequestDto requestDto);
        
    }
}
