using Microsoft.AspNetCore.Mvc;

namespace ValidationTurtorial.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}