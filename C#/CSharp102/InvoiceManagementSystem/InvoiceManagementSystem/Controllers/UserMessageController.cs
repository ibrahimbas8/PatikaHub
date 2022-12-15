﻿using InvoiceManagementSystem.Data;
using InvoiceManagementSystem.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace InvoiceManagementSystem.Controllers
{
    [Authorize (Roles ="User")]
    public class UserMessageController : Controller
    {
        private readonly InvoiceManagementSystemContext _context;

        public UserMessageController(InvoiceManagementSystemContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult Send()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Send([Bind("Subject,MessageDetails")] Message message)
        {
            var userName = User.Identity.Name;
            var loginUser = _context.Logins.FirstOrDefault(x => x.UserName == userName);
            var userId = loginUser.UserId;

            message.SenderID = userId;
            message.ReceiverID = 3;//admin
            if (ModelState.IsValid)
            {
                _context.Messages.Add(message);
                await _context.SaveChangesAsync();

                return RedirectToAction("Send", "UserMessage");
            }
            return View(message);

        }
    }
}
