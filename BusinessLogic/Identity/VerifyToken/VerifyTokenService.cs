using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace BusinessLogic.Identity.VerifyToken
{
    public class VerifyTokenService : IVerifyTokenService
    {
        private readonly IConfiguration _configuration;
        public VerifyTokenService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public ClaimsPrincipal VerifyToken(string token)
        {

            JwtSecurityTokenHandler tokenHandler = new JwtSecurityTokenHandler();

            var claims = tokenHandler.ValidateToken(token.Replace("Bearer ", ""),
                new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Secret"])),
                    ValidateLifetime = true,
                    ValidateAudience = false,
                    ValidateIssuer = false,
                    ClockSkew = TimeSpan.Zero
                }, out SecurityToken validatedToken);
            return claims;
        }

    }
}