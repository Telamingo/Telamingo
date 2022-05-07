using System.Security.Claims;

namespace BusinessLogic.Identity.VerifyToken
{
    public interface IVerifyTokenService
    {
        ClaimsPrincipal VerifyToken(string token);
    }
}