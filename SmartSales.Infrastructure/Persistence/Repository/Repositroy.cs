using SmartSales.Domain.Common;
using SmartSales.Domain.Interface.Repositroy;

namespace SmartSales.Infrastructure.Persistence.Repository;

public class Repository<T> : IRepository<T> where T : BaseEntity
{
    
    public Task<T> AddAsync(T entity)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(T entity)
    {
        throw new NotImplementedException();
    }

    public Task<T?> GetByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<T>> ListAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(T entity)
    {
        throw new NotImplementedException();
    }
}