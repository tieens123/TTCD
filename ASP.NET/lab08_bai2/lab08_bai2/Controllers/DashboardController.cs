using Microsoft.AspNetCore.Mvc;

namespace lab08_bai2.Controllers
{
    public class DashboardController : Controller
    {
        [Area("Admins")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
