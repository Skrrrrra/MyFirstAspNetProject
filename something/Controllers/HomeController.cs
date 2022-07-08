using Microsoft.AspNetCore.Mvc;


namespace something.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AboutAss()
        {
            return View();
        }

        public IActionResult Customers()
        {
            return View();
        }
    }
}
