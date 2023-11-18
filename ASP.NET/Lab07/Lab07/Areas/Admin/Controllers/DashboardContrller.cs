using Microsoft.AspNetCore.Mvc;

namespace Lab07.Areas.Admin.Controllers
{
    [Area("Admin")]

    public class DashboardContrller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
