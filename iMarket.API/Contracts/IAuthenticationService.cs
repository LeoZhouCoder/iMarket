using System.Threading.Tasks;
using iMarket.API.Commands;
using iMarket.API.Models;
using iMarket.API.Auth;
namespace iMarket.API.Services
{
    public interface IAuthenticationService
    {
        Task<JsonWebToken> SignUp(CreateUser user);
        Task<JsonWebToken> SignIn(string email, string password);
    }
}
