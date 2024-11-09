using LoginRegister.Data;
using LoginRegister.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages.Manage;

namespace LoginRegister.Controllers
{
    public class AccountController : Controller
    {
        private ApplicationDbContext _db;
        
        public AccountController(ApplicationDbContext db)
        {
            _db = db;
        }


        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(string Username, string Password, string cPassword, string Email)
        {
            if (Password != cPassword)
            {
                return View();
            }
            if (string.IsNullOrEmpty(Username) || string.IsNullOrEmpty(Password) || string.IsNullOrEmpty(cPassword) || string.IsNullOrEmpty(Email))
            {
                return View();
            }

            var user = new User
            {
                Username = Username,
                Password = Password,
                Email = Email
            };

            _db.Users.Add(user);
            _db.SaveChanges();
            return RedirectToAction("Login","Account");
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string Username, string Password)
        {
            var user = _db.Users.FirstOrDefault(u => u.Username == Username && u.Password == Password);
            if (user == null)
            {
                return View();
            }
            return RedirectToAction("Index", "Home");
        }
    }
}
