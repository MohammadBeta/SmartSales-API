using SmartSales.Domain.Entites;

namespace SmartSales.Domain.Interface.Repositroy;

public interface IUserRepository : IRepository<User>
{
    Task<User?> GetByEmailAsync(string email);
}