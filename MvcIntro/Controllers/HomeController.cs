using Microsoft.AspNetCore.Mvc;

namespace MvcIntro.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
