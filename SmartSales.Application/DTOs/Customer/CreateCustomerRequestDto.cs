using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartSales.Application.DTOs.Customer
{
    public class CreateCustomerRequestDto
    {
        public string Name { get; set; } = null!;

        public string Phone { get; set; } = string.Empty;

        public string Address { get; set; } = string.Empty;
    }
}
