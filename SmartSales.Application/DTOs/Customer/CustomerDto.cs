using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartSales.Application.DTOs.Customer
{
    public class CustomerDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = null!;

        public string Phone { get; set; } = string.Empty;

        public string Address { get; set; } = string.Empty;

        public decimal Balance { get; set; } = 0;

        public bool IsActive { get; set; } = true;
    }
}
