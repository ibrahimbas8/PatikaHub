using InvoiceManagementSystem.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace InvoiceManagementSystem.Controllers
{
    [Authorize(Roles = "User")]
    public class UserDuesController : Controller
    {
        private readonly InvoiceManagementSystemContext _context;

        public UserDuesController(InvoiceManagementSystemContext context)
        {
            _context = context;
        }
        // GET: Users
        
        public async Task<IActionResult> Index()
        {
            var userName = User.FindFirstValue(ClaimTypes.Name);
            var loginUser = _context.Logins.FirstOrDefault(x => x.UserName == userName);
            var userId = loginUser.UserId;

            var user = _context.Users.FirstOrDefault(x => x.UserId == userId);
            ViewBag.userName = user.FirstName;
            ViewBag.lastName = user.LastName;
            return View(await _context.Dues.Where(x => x.UserID == userId).ToListAsync());
        }
    }
}
