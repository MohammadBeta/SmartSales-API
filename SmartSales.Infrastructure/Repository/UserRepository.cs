using Microsoft.EntityFrameworkCore;
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
    class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(SmartSalesDbContext context) : base(context)
        {

        }

        public async Task<User?> GetUserByEmailAsync(string email)
        {
           return await Query().FirstOrDefaultAsync(u => u.Email == email);
        }
    }
}
