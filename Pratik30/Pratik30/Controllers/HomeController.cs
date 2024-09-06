using Microsoft.AspNetCore.Mvc;

namespace Pratik30.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
