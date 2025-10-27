using SmartSales.Domain.Entites;
using SmartSales.Domain.Interface.Repositroy;

namespace SmartSales.Infrastructure.Persistence.Repository;

public class UserRepository : Repository<User>, IUserRepository
{
    public Task<User?> GetByEmailAsync(string email)
    {
        throw new NotImplementedException();
    }
}