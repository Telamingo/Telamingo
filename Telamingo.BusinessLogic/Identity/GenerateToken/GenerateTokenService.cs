using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Telamingo.Domain.Dtos.AdminDtos;
using Telamingo.Domain.Dtos.User;

namespace Telamingo.BusinessLogic.Identity.GenerateToken;

public class GenerateTokenService : IGenerateTokenService
{
    private readonly IConfiguration configuration;
    public GenerateTokenService(IConfiguration iconfiguration)
    {
        configuration = iconfiguration;
    }
    public string Authenticate(UserDto user)
    {
        var tokenHandler = new JwtSecurityTokenHandler();
        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["Jwt:Key"]));
        var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
        var claims = new List<Claim>
            {
                new Claim(JwtRegisteredClaimNames.UniqueName, user.Password),
                new Claim(ClaimTypes.Email, user.Email),
                new Claim("UserId", user.Id.ToString())
            };

        var token = new JwtSecurityToken(
            issuer: configuration["JWT:Issuer"],
            audience: configuration["JWT:Audience"],
            claims: claims,
            expires: DateTime.Now.AddMinutes(30),
            signingCredentials: creds);

        var jwtString = tokenHandler.WriteToken(token);

        return jwtString;
    }

    public string AdminAuthentication(AdminDto admin)
    {
        var tokenHandler = new JwtSecurityTokenHandler();
        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["Jwt:Key"]));
        var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
        var claims = new List<Claim>
            {
                new Claim(JwtRegisteredClaimNames.UniqueName, admin.UserName),
                new Claim("AdminId", admin.Id.ToString())
            };

        var token = new JwtSecurityToken(
            issuer: configuration["JWT:Issuer"],
            audience: configuration["JWT:Audience"],
            claims: claims,
            expires: DateTime.Now.AddMinutes(30),
            signingCredentials: creds);

        var jwtString = tokenHandler.WriteToken(token);

        return jwtString;
    }

}
