using FinalProject.Application.DTOs.Identity;
using FinalProject.Application.DTOs.Identity.User;
using FinalProject.Web.Areas.Admin.ServiceFacades;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class LoginController : Controller
    {
        private readonly LoginServiceFacade _loginServiceFacade;

        public LoginController(LoginServiceFacade loginServiceFacade)
        {
            _loginServiceFacade = loginServiceFacade;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(Login loginUser)
        {
            var loginResult = await _loginServiceFacade.Login(loginUser);
            if (loginResult)
            {
                ViewBag.UserName = loginUser.UserName;
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ModelState.AddModelError("email", "Invalid username or password.");
                return View(loginUser);
            }
            
        }

        public IActionResult Logout() 
        {
            HttpContext.Session.Clear();
            return Redirect("Login");
        }

        [HttpPost]
        public async Task<IActionResult> Registr(UserAddDTO registr)
        {
            var loginResult = await _loginServiceFacade.Registr(registr);
            if (loginResult.Item1)
            {
                return RedirectToAction("Login");
            }
            else
            {
                ModelState.AddModelError("email", loginResult.Item2);
                return View(registr);
            }

        }
    }
}
