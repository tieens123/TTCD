using Lession04.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Lession04.Controllers
{
    public class CategoryController : Controller
    {
        //public static List<Category> _contex = DataLocal._categories;
        // GET: CategoryController
        public ActionResult Index()
        {
            var data = DataLocal._categories;
            return View(data);
        }

        // GET: CategoryController/Details/5
        public ActionResult Details(int id)
        {
            var data = DataLocal._categories.FirstOrDefault(x => x.Id == id);
            return View(data);
        }

        // GET: CategoryController/Create
        public ActionResult Create()
        {
            var Id = DataLocal._categories.MaxBy(x=>x.Id).Id;
            ViewBag.Id = Id+1;
            return View();
        }

        // POST: CategoryController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Category category)
        {
            try
            {
                //cập nhật giá trị cho các cột ẩn
                category.CreateDate = DateTime.Now;
                category.CreateBy = "tieens";
                //thêm đối tượng category vào list _categories trong datalocal
                DataLocal._categories.Add(category);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CategoryController/Edit/5
        public ActionResult Edit(int id)
        {
            var data = DataLocal._categories.FirstOrDefault(x=>x.Id==id);
            return View(data);
        }

        // POST: CategoryController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Category category)
        {
            try
            {
                //cập nhật dữ liệu trong datalocal
                for (int i = 0; i<DataLocal._categories.Count;i++)
                {
                    if (DataLocal._categories[i].Id==id)
                    {
                        DataLocal._categories[i] = category;
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

        // GET: CategoryController/Delete/5
        public ActionResult Delete(int id)
        {
            var data = DataLocal._categories.FirstOrDefault(x=>x.Id == id); 
            return View(data);
        }

        // POST: CategoryController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Category category)
        {
            try
            {
                foreach (var item in DataLocal._categories)
                {
                    if (item.Id == id)
                    {
                        DataLocal._categories.Remove(item);
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
