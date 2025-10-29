
using SmartSales.Domain.Interface.Repositroy;

namespace SmartSales.Domain.Interface;
public interface IUnitOfWork : IDisposable
{
    IUserRepository Users { get; }
    Task<int> CompleteAsync();
}