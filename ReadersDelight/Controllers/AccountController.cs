using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;

namespace ReadersDelightWeb.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Login(string returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;
            return View();
        }
        [HttpPost]
        public  IActionResult Login(string username,string password,string returnUrl)
        {
            // Your login logic here
            // Check username and password, validate credentials
            // If successful, sign in the user using authentication mechanisms
            // For demonstration purposes, redirecting back to the returnUrl if provided, else to the home page
            if(!string.IsNullOrEmpty(returnUrl) && Url.IsLocalUrl(returnUrl))
            {
                return Redirect(returnUrl);
            }
            else
            {
                return RedirectToAction(nameof(Index), "Home");
            }
        }
        public IActionResult Register()
        {
            return View();
        }
        public IActionResult Logout()
        {
            // Your logout logic here
            // Sign out the user using authentication mechanisms

            return RedirectToAction(nameof(Index), "Home");
        }
    }
}
