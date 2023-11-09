using lesson05.Models.DataModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.RegularExpressions;

namespace lesson05.Controllers
{
    public class MemberController : Controller
    {
        // GET: MemberController
        public static List<Member> list = new List<Member>();
        public ActionResult Index()
        {
            return View(list);
        }

        // GET: MemberController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MemberController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MemberController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Member member)
        {
            //menual Validation
            string msg = "";
            bool validate = true;
            if (member.UserName.Length < 3 || member.UserName.Length >20)
            {
                msg = "<li> Username có độ dài từ 3-20 kí tự </li>";
                validate = false;
            }
            //kiểm tra email đúng định dạng
            string patternEmail = @"[a-zA-Z0-9._+-]+@[a-z0-9._]+\.[a-z]{2,4}$";
            if (!Regex.IsMatch(member.Email, patternEmail))
            {
                msg += "<li> Email chưa nhập đúng định dạng (example@gmail.com) </li>";
                validate |= false;
            }
            //kiểm tra năm sinh phải đủ 18 tuổi
            if (member.Birthday.Value.AddYears(18) > DateTime.Now)
            {
                msg += "<li> bạn chưa đủ 18 tuổi </li>";
                validate = false;
            }
            //kiểm tra điện thoại phải là số
            string patternPhone = @"^0\d{9,11}";
            if (!Regex.IsMatch(member.Phone, patternPhone))
            {
                msg += "<li> điện thoại bạn chưa đúng  </li>";
                validate = false;

            }
            if (validate == true)
            {
                member.MenberId = Guid.NewGuid().ToString();
                list.Add(member);
                return RedirectToAction(nameof(Index));
            }
            else
            {
                ViewBag.msg = "<div class='alert alert-danger'>" +msg+ "</div>";
                return View(member);
            }
        }

        // GET: MemberController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MemberController/Edit/5
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

        // GET: MemberController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MemberController/Delete/5
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
