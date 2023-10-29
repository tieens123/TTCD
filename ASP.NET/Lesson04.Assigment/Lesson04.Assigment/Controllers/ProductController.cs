using Lesson04.Assigment.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Lesson04.Assigment.Controllers
{
    public class ProductController : Controller
    {
        // GET: ProductController
        public ActionResult Index()
        {
            var data = DataLocal._products;
            return View(data);
        }

        // GET: ProductController/Details/5
        public ActionResult Details(int id)
        {
            var data = DataLocal._products.FirstOrDefault(p => p.Id == id);
            // Tạo dữ liệu cho ComboBox (Category)
            ViewData["CategoryId"] = new SelectList(DataLocal._categories, "Id", "Name", data.CategoryId);

            return View(data);
        }

        // GET: Product/Create
        public ActionResult Create()
        {
            // Tạo dữ liệu cho ComboBox (Category)
            ViewData["CategoryId"] = new SelectList(DataLocal._categories, "Id", "Name", 1);
            // Tạo mã sản phảm tự tăng
            var id = DataLocal._products.MaxBy(x => x.Id).Id;
            ViewBag.id = id+1;
            return View();
        }

        // POST: Product/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Product product)
        {
            try
            {
                //Upload file
                var files = HttpContext.Request.Form.Files;
                if(files.Count()>0 && files[0] != null)
                {
                    var file = files[0];
                    var fileName = file.FileName.ToLower();
                    // Tạo thư mục trên server để chứa tệp tin
                    // wwwroot/images/products/
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\images\\products", fileName);
                    using(var stream = new FileStream(path, FileMode.Create))
                    {
                        file.CopyTo(stream);
                        product.Image = "images/products/" + fileName;
                    }
                }
                product.CreateDate = DateTime.Now;
                product.CreateBy = "ChungChung";

                DataLocal._products.Add(product);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(product);
            }
        }

        // GET: Product/Edit/5
        public ActionResult Edit(int id)
        {
            var data = DataLocal._products.FirstOrDefault(p => p.Id == id);
            // Tạo dữ liệu cho ComboBox (Category)
            ViewData["CategoryId"] = new SelectList(DataLocal._categories, "Id", "Name", data.CategoryId);
            return View(data);
        }

        // POST: Product/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Product product)
        {
            try
            {
                //Upload file
                var files = HttpContext.Request.Form.Files;
                if (files.Count() > 0 && files[0] != null)
                {
                    var file = files[0];
                    var fileName = file.FileName.ToLower();
                    // Tạo thư mục trên server để chứa tệp tin
                    // wwwroot/images/products/
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\images\\products", fileName);
                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        file.CopyTo(stream);
                        product.Image = "images/products/" + fileName;
                    }
                }

                // Cập nhật dữ liệu trong DataLocal
                for (int i = 0; i < DataLocal._products.Count; i++)
                {
                    if (DataLocal._products[i].Id == id)
                    {
                        DataLocal._products[i] = product;
                        break;
                    }
                }

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductController/Delete/5
        public ActionResult Delete(int id)
        {
            var data = DataLocal._products.FirstOrDefault(x => x.Id == id);

            return View(data);
        }

        // POST: ProductController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Product product)
        {
            try
            {
                foreach (var item in DataLocal._products)
                {
                    if (item.Id == id)
                    {
                        DataLocal._products.Remove(item);
                        break;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
