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

        public UnitOfWork(SmartSalesDbContext context, IUserRepository userRepository, IProductRepository productRepository)
        {
            _context = context;
            Users = userRepository;
            Products = productRepository;
        }

        public IUserRepository Users { get; private set; }
        public IProductRepository Products { get; private set; }

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
