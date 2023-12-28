using Microsoft.AspNetCore.Mvc;

namespace HamburgueriaSana.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
