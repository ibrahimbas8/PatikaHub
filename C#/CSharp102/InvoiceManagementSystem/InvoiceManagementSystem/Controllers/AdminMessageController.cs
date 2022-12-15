using InvoiceManagementSystem.Data;
using InvoiceManagementSystem.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace InvoiceManagementSystem.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminMessageController : Controller
    {
        private readonly InvoiceManagementSystemContext _context;

        public AdminMessageController(InvoiceManagementSystemContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Inbox()
        {
            return View(await _context.Messages.ToListAsync());
        }
    }
}
