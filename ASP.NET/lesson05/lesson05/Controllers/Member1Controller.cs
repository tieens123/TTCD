using lesson05.Models.DataModels;
using lesson05.Models.ModelViews;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace lesson05.Controllers
{
    public class Member1Controller : Controller
    {
        // GET: Member1Controller
        private static List<Member> _members = new List<Member>();
        public ActionResult Index()
        {

            return View();
        }

        // GET: Member1Controller/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Member1Controller/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Member1Controller/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(MemberView member)
        {
            if (ModelState.IsValid)
            {
                var model = new Member()
                {
                    MenberId = Guid.NewGuid().ToString(),
                    UserName = member.UserName,
                    FullName = member.FullName,
                    Password = member.Password, 
                    Email = member.Email,
                    Phone = member.Phone,
                    Birthday = member.Birthday,
                };
                _members.Add(model);
                return RedirectToAction(nameof(Index));

            }
            else
            {
                return View(member);

            }


        }

        // GET: Member1Controller/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Member1Controller/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Member1Controller/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Member1Controller/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
