using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using LoginPOC.Models;

namespace LoginPOC.Controllers
{
    public class HomeController : Controller
    {
        private static readonly Dictionary<string, AccountViewModel> _accounts = new()
        {
            { 
                // Password (in quotes): "AdminPassword123"
                "A481AD1053F744255C4A027B3819C793592E2D1EF332737BC43AF9DA658385D7",
                new()
                {
                    Forename = "Admin",
                    Surname = "Account",
                    Email = "admin.account@example.com",
                    Phone = "+00 0123 456789"
                }
            },
            { 
                // Password (in quotes): "Hello, World!"
                "2D17749971040EC60CAC3EDC06B53E4E22AB9A8FE0F301996200CDAF8E09402E",
                new()
                {
                    Forename = "Daniella",
                    Surname = "Potts",
                    Email = "DaniellaJPotts@gmail.com",
                    Phone = "+44 7341 696857"
                }
            }
        };

        public IActionResult Index(LoginViewModel login)
        {
            return View(login);
        }

        public IActionResult Authentication(LoginViewModel login)
        {
            if (login.Email is null || login.Password is null) return RedirectToAction("Index");

            string loginHash = login.GetHashCode();
            bool accountExists = _accounts.TryGetValue(loginHash, out AccountViewModel? account);
            if (!accountExists) return RedirectToAction("Index", new LoginViewModel() { ErrorMessage = "Incorrect email or password, please try again." });

            account!.LastLoginAttempt = DateTime.UtcNow.Ticks;
            AuthenticationViewModel AVM = new()
            {
                AccountHash = loginHash,
                Name = account.GetName(),
                PhoneEnding = account.GetPhoneEnding(),
                AuthnCodePOC = account.GetAuthenticationCode()
            };
            return View(AVM);
        }

        public IActionResult Welcome(AuthenticationViewModel authentication)
        {
            if (authentication.AccountHash is null) return RedirectToAction("Index");

            bool accountExists = _accounts.TryGetValue(authentication.AccountHash, out AccountViewModel? account);
            if (!accountExists) return RedirectToAction("Index");
            // If the authentication code is older than 5 minuites return to Index.
            if (account!.LastLoginAttempt + ((long)10000000 * 60 * 5) < DateTime.UtcNow.Ticks)
                return RedirectToAction("Index", new LoginViewModel() { ErrorMessage = "Authentication code timed out, please try again." });
            // If the authentication code is valid return to Welcome, else Index.
            return (account!.GetAuthenticationCode() == authentication.AuthnCode)
                ? View(account)
                : RedirectToAction("Index", new LoginViewModel() { ErrorMessage = "Incorrect authentication code, please try again." });
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}