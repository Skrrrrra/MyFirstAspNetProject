using Microsoft.AspNetCore.Mvc;
using something.Service;

namespace something.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Service.Config.Name = "MySuperCompany";

            return View();
        }
        
        
    }
}
