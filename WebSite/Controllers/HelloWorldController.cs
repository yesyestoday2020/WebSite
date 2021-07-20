using Microsoft.AspNetCore.Mvc;

namespace WebSite.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}