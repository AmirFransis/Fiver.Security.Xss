using Microsoft.AspNetCore.Mvc;

namespace Fiver.Security.Xss.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
