using System.Security.Claims;
using System.Text;
using Microsoft.IdentityModel.JsonWebTokens;
using Microsoft.IdentityModel.Tokens;
using SmartSales.Application.Interfaces;
using SmartSales.Infrastructure.Options;

namespace SmartSales.Infrastructure.Security
{
    public class JwtTokenGenerator : IJwtTokenGenerator
    {
        private readonly JwtOptions _jwtOptions;
        public JwtTokenGenerator(Microsoft.Extensions.Options.IOptions<JwtOptions> jwtOptions)
        {
            _jwtOptions = jwtOptions.Value;
        }
        public string GenerateToken(Guid userId, string email, string firstName, string lastName)
        {
            var claims = new[]
            {
                new System.Security.Claims.Claim(JwtRegisteredClaimNames.Sub, userId.ToString()),
                new System.Security.Claims.Claim(JwtRegisteredClaimNames.Email, email),
                new System.Security.Claims.Claim(JwtRegisteredClaimNames.GivenName, firstName),
                new System.Security.Claims.Claim(JwtRegisteredClaimNames.FamilyName, lastName),
                new System.Security.Claims.Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
            };
            var sigingKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtOptions.SecretKey));
            var credentials = new SigningCredentials(sigingKey, SecurityAlgorithms.HmacSha256);

            var handler = new JsonWebTokenHandler();
            string jwt = handler.CreateToken(new SecurityTokenDescriptor
            {
                Issuer = _jwtOptions.Issuer,
                Audience = _jwtOptions.Audience,
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.UtcNow.AddMinutes(_jwtOptions.ExpirationInMinutes),
                SigningCredentials = credentials
            });
            return jwt;
        }
    }
}