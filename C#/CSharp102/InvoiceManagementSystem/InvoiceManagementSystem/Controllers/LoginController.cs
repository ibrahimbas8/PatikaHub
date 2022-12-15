using InvoiceManagementSystem.Models;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using InvoiceManagementSystem.Data;
using System.Linq;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Authorization;

namespace InvoiceManagementSystem.Controllers
{
    public class LoginController : Controller
    {
        private readonly InvoiceManagementSystemContext _context;

        public LoginController(InvoiceManagementSystemContext context)
        {
            _context = context;
        }

        [HttpGet("login")]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost("login")]
        public async Task<IActionResult> Validate(Login login)
        {
            var userData = _context.Logins.FirstOrDefault(x => x.UserName == login.UserName && x.Password == login.Password);
            if (userData != null)
            {
                var claims = new List<Claim>();
                claims.Add(new Claim(ClaimTypes.Name, userData.UserName));
                claims.Add(new Claim(ClaimTypes.Role, userData.RoleName));

                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
                await HttpContext.SignInAsync(claimsPrincipal);
                return RedirectToAction("Index", "Home");
            }
            TempData["Error"] = "Hata kullanıcı adı veya şifresi hatalı.";
            return View("login");
        }
        [HttpGet("denied")]
        public IActionResult Denied()
        {
            return View();
        }
    }
}
