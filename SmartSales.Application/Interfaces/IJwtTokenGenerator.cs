namespace SmartSales.Application.Interfaces
{
    public interface IJwtTokenGenerator
    {
        string GenerateToken(Guid userId, string email, string firstName, string lastName);
    }
}