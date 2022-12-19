using InvoiceManagementSystem.Data;
using InvoiceManagementSystem.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Data;
using System.Dynamic;
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
            var messageList = await _context.Messages.Where(user => user.SenderID != 3).ToListAsync();
            return View(messageList);
        }

        [HttpGet]
        public IActionResult Send()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Send([Bind("Subject,MessageDetails")] Message message)
        {
            if (ModelState.IsValid)
            {
                var userList = await _context.Users.ToListAsync();
                var messageList = new List<Message>();
                foreach (var user in userList)
                {
                    messageList.Add(new Message { MessageDetails = message.MessageDetails, ReceiverID = user.UserId, SenderID = 3, Subject = message.Subject, MessageStatus=message.MessageStatus, MessageDate=message.MessageDate });
                }
                await _context.Messages.AddRangeAsync(messageList);
                await _context.SaveChangesAsync();

                return RedirectToAction("Send", "AdminMessage");
            }
            
            return View(message);
        }
    }
}
