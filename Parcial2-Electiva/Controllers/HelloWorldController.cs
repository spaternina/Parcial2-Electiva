using Microsoft.AspNetCore.Mvc;

namespace Parcial2_Electiva.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Welcome()
        {
            return View();
        }
    }
}
