using Microsoft.AspNetCore.Mvc;
using Lab09.Models;



namespace Lab09.Controllers
{
    public class ProductController : Controller
    {

        private readonly DevXuongMocContext _context;
        public ProductController(DevXuongMocContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var data = await _context.Products.ToListAsync();
            return View(data);
        }
    }
}
