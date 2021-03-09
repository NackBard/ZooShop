using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MyEShop.Models;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Claims;
using System.Threading.Tasks;

namespace MyEShop.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationContext db;
        private readonly ArticlesRepository ar;

        public HomeController(ApplicationContext context, ArticlesRepository articles)
        {
            this.db = context;
            this.ar = articles;
        }

        [Authorize]
        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> Catalog()
        {
            return View(await db.Products.ToListAsync());
        }
        public IActionResult Contacts()
        {
            return View();
        }
        public IActionResult PersonalArea()
        {
            return View();
        }
        public IActionResult PickUpPoints()
        {
            return View();
        }
        public IActionResult Delivery()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Vhod()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Vhod(LogModel model)
        {
            if (ModelState.IsValid)
            {
                Users user = await db.Users.FirstOrDefaultAsync(u => u.Email == model.Email && u.Password == model.Password);
                if (user != null)
                {
                    await Authenticate(model.Email); // аутентификация

                    return RedirectToAction("Index", "Home");
                }
                ModelState.AddModelError("", "Некорректные логин и(или) пароль");
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult Reg()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Reg(Users user)
        {
            if (ModelState.IsValid)
            {
                Debug.Write("Вы зарегистрировались");
                ar.SaveArticle(user);
                return View();

            }
            else
                return View(user);
        }

        public async Task Authenticate(string userName)
        {
            // создаем один claim
            var claims = new List<Claim>
            {
                new Claim(ClaimsIdentity.DefaultNameClaimType, userName)
            };
            // создаем объект ClaimsIdentity
            ClaimsIdentity id = new ClaimsIdentity(claims, "ApplicationCookie", ClaimsIdentity.DefaultNameClaimType, ClaimsIdentity.DefaultRoleClaimType);
            // установка аутентификационных куки
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(id));
        }

    }
}
