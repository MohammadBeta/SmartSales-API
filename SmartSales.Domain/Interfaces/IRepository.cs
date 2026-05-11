
using SmartSales.Domain.Common;

namespace SmartSales.Domain.Interfaces;

public interface IRepository<T> where T : BaseEntity
{
    Task<T?> GetByIdAsync(Guid id);
    Task<IEnumerable<T>> GetAllAsync();
    Task AddAsync(T entity);
    Task UpdateAsync(T entity);
    void Delete(T entity);
    IQueryable<T> Query();

}