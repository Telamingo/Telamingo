using System.Security.Claims;

namespace Telamingo.BusinessLogic.Identity.VerifyToken;

public interface IVerifyTokenService
{
    ClaimsPrincipal VerifyToken(string token);
}
