using Microsoft.AspNetCore.Mvc;
using lab02.Models;
using System.Linq;
namespace lab02.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
