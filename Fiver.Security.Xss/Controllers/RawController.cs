using Microsoft.AspNetCore.Mvc;
using Fiver.Security.Xss.OtherLayers;
using Fiver.Security.Xss.Models;

namespace Fiver.Security.Xss.Controllers
{
    public class RawController : Controller
    {
        private readonly IMovieService service;

        public RawController(IMovieService service)
        {
            this.service = service;
        }

        public IActionResult Index()
        {
            HttpContext.Response.Cookies.Append("secret", "password");

            var outputModel = new MovieOutputModel();
            return View(outputModel);
        }

        [HttpPost]
        public IActionResult Index(string filter)
        {
            var model = this.service.GetMovies(filter ?? "");

            var outputModel = new MovieOutputModel
            {
                Filter = filter,
                Movies = model
            };

            HttpContext.Response.Headers.Add("X-XSS-Protection", "0");

            return View(outputModel);
        }
    }
}
