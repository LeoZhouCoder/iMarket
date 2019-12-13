using iMarket.API.Auth;

namespace iMarket.API.Models
{
    public class AuthenticationResult
    {
        public bool Success { get; set; }
        public JsonWebToken Token { get; set; }
    }
}
