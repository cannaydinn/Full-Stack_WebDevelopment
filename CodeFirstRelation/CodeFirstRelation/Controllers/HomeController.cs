using Microsoft.AspNetCore.Mvc;

namespace CodeFirstRelation.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return Ok();
        }
    }
}
