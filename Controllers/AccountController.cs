using Microsoft.AspNetCore.Mvc;
using IT_ELECTIVE_3_Midterm.Models;

namespace IT_ELECTIVE_3_Midterm.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            if (model.Username == "admin" &&
                model.Password == "123456")
            {
                return RedirectToAction("Welcome");
            }

            ModelState.AddModelError(string.Empty,
                "Invalid username or password.");

            return View(model);
        }

        public IActionResult Welcome()
        {
            return View();
        }
    }
}