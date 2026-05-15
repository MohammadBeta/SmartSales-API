using SmartSales.Domain.Entities;
using SmartSales.Domain.Interfaces;
using SmartSales.Infrastructure.Presistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartSales.Infrastructure.Repository
{
    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        public CustomerRepository(SmartSalesDbContext context) : base(context)
        {
        }
    }
}
