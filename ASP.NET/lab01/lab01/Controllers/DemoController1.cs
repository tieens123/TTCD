using Microsoft.AspNetCore.Mvc;

namespace Lab01.Controllers
{
    public class DemoController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
