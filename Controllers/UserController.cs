using Microsoft.AspNetCore.Mvc;
using YogaClassManagement.Models;

namespace YogaClassManagement.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(User user)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Login");
            }
            return View(user);
        }
    }
}
