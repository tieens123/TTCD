using Microsoft.AspNetCore.Mvc;
using lab02.Models;
using System.Linq;
namespace lab02.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            List<Account> accounts = new List<Account>
            {
                new Account()
                {
                    Id = 1,
                    Name="lap",
                    Email="anh@gmail.com",
                    Phone="09876645456",
                    Address="Hà Nội",
                    Avatar=Url.Content("~/images/avatar/anh4.jpg"),
                    Gender=1,
                    Bio="1000vnd",
                    Birthday= new DateTime(1990,2,21)
                },
                new Account()
                {
                    Id = 2,Name="mobie",
                    Email="anh@gmail.com",
                    Phone="09876645456",
                    Address="Hà Nội",
                    Avatar=Url.Content("~/images/avatar/anh5.jpg"),
                    Gender=1,Bio="2000vnd",
                    Birthday= new DateTime(1990,2,21)
                },
                new Account()
                {
                    Id = 3,Name="iPad",
                    Email="anh@gmail.com",
                    Phone="09876645456",
                    Address="Hà Nội",
                    Avatar=Url.Content("~/images/avatar/anh6.jpg"),
                    Gender=1,Bio="3000vnd",
                    Birthday= new DateTime(1990,2,21)
                },
            };
            ViewBag.Accounts = accounts;
            return View();
        }

        //định nghĩa url và nam cho action
        [Route("ho-so-cua-toi",Name ="profile")]
        public IActionResult Profile(int id)
        {
            //danh sách account như trên action index
            List<Account> accounts = new List<Account>
            {
                new Account()
                {
                    Id = 1,
                    Name="lap",
                    Email="anh@gmail.com",
                    Phone="09876645456",
                    Address="Hà Nội",
                    Avatar=Url.Content("~/images/avatar/anh4.jpg"),
                    Gender=1,
                    Bio="1000vnd",
                    Birthday= new DateTime(1990,2,21)
                },
                new Account()
                {
                    Id = 2,Name="mobie",
                    Email="anh@gmail.com",
                    Phone="09876645456",
                    Address="Hà Nội",
                    Avatar=Url.Content("~/images/avatar/anh5.jpg"),
                    Gender=1,Bio="2000vnd",
                    Birthday= new DateTime(1990,2,21)
                },
                new Account()
                {
                    Id = 3,Name="iPad",
                    Email="anh@gmail.com",
                    Phone="09876645456",
                    Address="Hà Nội",
                    Avatar=Url.Content("~/images/avatar/anh6.jpg"),
                    Gender=1,Bio="3000vnd",
                    Birthday= new DateTime(1990,2,21)
                },new Account()
                {
                    Id = 1,
                    Name="lap",
                    Email="anh@gmail.com",
                    Phone="09876645456",
                    Address="Hà Nội",
                    Avatar=Url.Content("~/images/avatar/anh4.jpg"),
                    Gender=1,
                    Bio="1000vnd",
                    Birthday= new DateTime(1990,2,21)
                },
                new Account()
                {
                    Id = 2,Name="mobie",
                    Email="anh@gmail.com",
                    Phone="09876645456",
                    Address="Hà Nội",
                    Avatar=Url.Content("~/images/avatar/anh5.jpg"),
                    Gender=1,Bio="2000vnd",
                    Birthday= new DateTime(1990,2,21)
                },
                new Account()
                {
                    Id = 3,Name="iPad",
                    Email="anh@gmail.com",
                    Phone="09876645456",
                    Address="Hà Nội",
                    Avatar=Url.Content("~/images/avatar/anh6.jpg"),
                    Gender=1,Bio="3000vnd",
                    Birthday= new DateTime(1990,2,21)
                },
            };
            Account account = accounts.FirstOrDefault(ac => ac.Id == id);
            //Account account = new Account()
            //{
            //    Id = 1,
            //    Name = "Tiến",
            //    Email = "anh@gmail.com",
            //    Phone = "09876645456",
            //    Address = "Hà Nội",
            //    Avatar = Url.Content("~/images/avatar/anh1.jpg"),
            //    Gender = 1,
            //    Bio = "My name is small",
            //    Birthday = new DateTime(1990, 2, 21)
            //};
            //gửi đối tượng account qua view
            ViewBag.account = account;
            return View();
        }
    }
}
