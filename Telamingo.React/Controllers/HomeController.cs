using Microsoft.AspNetCore.Mvc;

namespace Telamingo.React.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
