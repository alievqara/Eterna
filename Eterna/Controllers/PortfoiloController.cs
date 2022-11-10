using Microsoft.AspNetCore.Mvc;

namespace Eterna.Controllers
{
    public class PortfoiloController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
