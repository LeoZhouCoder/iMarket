using Microsoft.AspNetCore.Mvc;

namespace iMarket.API.Controllers
{
    public class AuthenticationController : Controller
    {
        public AuthenticationController() { }
        public IActionResult Get()
        {
            return Content("Hello from iMarket Api");
        }
    }
}
