using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using LoginPOC.Models;

namespace LoginPOC.Controllers
{
    public class HomeController : Controller
    {
        private readonly Dictionary<string, AccountViewModel> _accounts = new Dictionary<string, AccountViewModel>()
        {
            { 
                // Password (in quotes): "AdminPassword123"
                "A481AD1053F744255C4A027B3819C793592E2D1EF332737BC43AF9DA658385D7",
                new AccountViewModel()
                {
                    Forename = "Admin",
                    Surname = "Account",
                    Email = "admin.account@example.com"
                }
            },
            { 
                // Password (in quotes): "Hello, World!"
                "2D17749971040EC60CAC3EDC06B53E4E22AB9A8FE0F301996200CDAF8E09402E",
                new AccountViewModel()
                {
                    Forename = "Daniella",
                    Surname = "Potts",
                    Email = "DaniellaJPotts@gmail.com"
                }
            }
        };

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Welcome(LoginViewModel login)
        {
            if (login.Email is null || login.Password is null) return RedirectToAction("Index");

            string loginHash = login.GetHashCode();
            bool accountExists = _accounts.TryGetValue(loginHash, out AccountViewModel? account);
            return accountExists ? View(account) : RedirectToAction("Index");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}