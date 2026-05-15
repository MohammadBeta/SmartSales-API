using SmartSales.Domain.Interfaces;
using SmartSales.Infrastructure.Presistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartSales.Infrastructure.UnitOfWork
{
    class UnitOfWork : IUnitOfWork
    {
        private readonly SmartSalesDbContext _context;
        public IUserRepository Users { get; private set; }
        public IProductRepository Products { get; private set; }
        public ICustomerRepository Customers { get; private set; }


        public UnitOfWork(SmartSalesDbContext context, IUserRepository userRepository, IProductRepository productRepository, ICustomerRepository customers)
        {
            _context = context;
            Users = userRepository;
            Products = productRepository;
            Customers = customers;
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public async Task<int> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
