using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace Fiver.Security.Xss.Controllers
{
    public class EncodingController : Controller
    {
        private readonly HtmlEncoder htmlEncoder;
        private readonly UrlEncoder urlEncoder;
        private readonly JavaScriptEncoder jsEncoder;

        public EncodingController(
            HtmlEncoder htmlEncoder,
            UrlEncoder urlEncoder,
            JavaScriptEncoder jsEncoder)
        {
            this.htmlEncoder = htmlEncoder;
            this.urlEncoder = urlEncoder;
            this.jsEncoder = jsEncoder;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Encoder()
        {
            ViewBag.Html = "<p>I am <strong>HTML</strong></p>";
            ViewBag.Url = "https://tahirnaushad.com/2017/08/16/asp-net-core-problem-solution-series/";
            ViewBag.Js = "<script>alert('oops');</script>";

            ViewBag.EncodedHtml = this.htmlEncoder.Encode(ViewBag.Html);
            ViewBag.EncodedUrl = this.urlEncoder.Encode(ViewBag.Url);
            ViewBag.EncodedJs = this.jsEncoder.Encode(ViewBag.Js);

            return View();
        }
    }
}
