using System.Security.Claims;

namespace iMarket.API.Auth
{
    public interface IJwtHandler
    {
        JsonWebToken Create(string userId, string userRole, bool isSignUp);
        ClaimsPrincipal ValidateToken(string token);
    }
}
