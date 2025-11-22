using BCrypt.Net;
using Microsoft.AspNetCore.Mvc;
using UserPortal.Models;
using System.Linq;

namespace UserPortal.Controllers
{
    
    public class AccountController : Controller
    {
        private readonly AppDbContext db;

        public AccountController(AppDbContext context)
        {
            db = context;
        }

        
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Register(RegisterViewModel model)
        {
            if (!ModelState.IsValid)
            {
                
                return View(model);
            }

            var exists = db.Users.Any(u => u.Email == model.Email);
            if (exists)
            {
                ModelState.AddModelError(string.Empty, "Email already registered");
                return View(model);
            }

            // hash password and save
            var hashed = BCrypt.Net.BCrypt.HashPassword(model.Password ?? "");

            var user = new User
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                Phone = model.Phone,
                Email = model.Email,
                Password = BCrypt.Net.BCrypt.HashPassword(model.Password)
            };
            
            db.Users.Add(user);
            db.SaveChanges();
 

            return RedirectToAction("MyAccount");
        }

        // GET
        public IActionResult Login()
        {
            return View();
        }

       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(LoginViewModel model)
        {
            if (!ModelState.IsValid) return View(model);

            var u = db.Users.SingleOrDefault(x => x.Email == model.Email);
            if (u == null)
            {
                ModelState.AddModelError(string.Empty, "Invalid credentials");
                return View(model);
            }

            var ok = BCrypt.Net.BCrypt.Verify(model.Password ?? "", u.Password ?? "");
            if (!ok)
            {
                ModelState.AddModelError(string.Empty, "Invalid credentials");
                return View(model);
            }

            HttpContext.Session.SetInt32("UserId", u.Id);
            HttpContext.Session.SetString("FirstName", u.FirstName ?? "User");

            return RedirectToAction("MyAccount");
        }

        
        public IActionResult MyAccount()
        {
            var id = HttpContext.Session.GetInt32("UserId");
            if (id == null) return RedirectToAction("Login");

            ViewBag.FirstName = HttpContext.Session.GetString("FirstName") ?? "User";
            return View();
        }

        // GET: /Account/Logout
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }
    }
}
