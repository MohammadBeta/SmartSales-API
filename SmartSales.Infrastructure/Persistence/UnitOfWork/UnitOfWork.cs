
using SmartSales.Domain.Interface;
using SmartSales.Domain.Interface.Repositroy;
using SmartSales.Infrastructure.Persistence.Repository;

namespace SmartSales.Infrastructure.Persistence.UnitOfWork;
public class UnitOfWork : IUnitOfWork
{
    private readonly SmartSalesDbContext _context;
    public IUserRepository Users { get; private set; }

    public UnitOfWork(SmartSalesDbContext context, IUserRepository userRepository)
    {
        _context = context;
        this.Users = userRepository;
    }

    public async Task<int> CompleteAsync()
    {
        return await _context.SaveChangesAsync();
    }

    public void Dispose()
    {
        _context.Dispose();
    }
}