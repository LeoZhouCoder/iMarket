using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;

namespace iMarket.API.Controllers
{
    public class HomeController : Controller
    {
        public HomeController() {}
        public IActionResult Get()
        {
            return Content("Hello from iMarket Api");
        }

        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public IActionResult AuthorizeGet()
        {
            return Content("Hello from iMarket Authorize Api");
        }
    }
}
