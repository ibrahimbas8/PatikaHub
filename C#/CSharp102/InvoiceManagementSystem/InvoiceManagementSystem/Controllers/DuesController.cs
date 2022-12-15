using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using InvoiceManagementSystem.Data;
using InvoiceManagementSystem.Models;
using Microsoft.AspNetCore.Authorization;
using System.Data;

namespace InvoiceManagementSystem.Controllers
{
    [Authorize(Roles = "Admin")]
    public class DuesController : Controller
    {
        private readonly InvoiceManagementSystemContext _context;

        public DuesController(InvoiceManagementSystemContext context)
        {
            _context = context;
        }

        // GET: Dues
        public async Task<IActionResult> Index()
        {
            var invoiceManagementSystemContext = _context.Dues.Include(d => d.User);
            return View(await invoiceManagementSystemContext.ToListAsync());
        }

        // GET: Dues/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dues = await _context.Dues
                .Include(d => d.User)
                .FirstOrDefaultAsync(m => m.DuesID == id);
            if (dues == null)
            {
                return NotFound();
            }

            return View(dues);
        }

        // GET: Dues/Create
        public IActionResult Create()
        {
            ViewData["UserID"] = new SelectList(_context.Set<User>(), "UserId", "UserId");
            return View();
        }

        // POST: Dues/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DuesID,Price,Date,Description,Status,UserID")] Dues dues)
        {
            if (ModelState.IsValid)
            {
                _context.Add(dues);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["UserID"] = new SelectList(_context.Set<User>(), "UserId", "UserId", dues.UserID);
            return View(dues);
        }

        // GET: Dues/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dues = await _context.Dues.FindAsync(id);
            if (dues == null)
            {
                return NotFound();
            }
            ViewData["UserID"] = new SelectList(_context.Set<User>(), "UserId", "UserId", dues.UserID);
            return View(dues);
        }

        // POST: Dues/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("DuesID,Price,Date,Description,Status,UserID")] Dues dues)
        {
            if (id != dues.DuesID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dues);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DuesExists(dues.DuesID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["UserID"] = new SelectList(_context.Set<User>(), "UserId", "UserId", dues.UserID);
            return View(dues);
        }

        // GET: Dues/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dues = await _context.Dues
                .Include(d => d.User)
                .FirstOrDefaultAsync(m => m.DuesID == id);
            if (dues == null)
            {
                return NotFound();
            }

            return View(dues);
        }

        // POST: Dues/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var dues = await _context.Dues.FindAsync(id);
            _context.Dues.Remove(dues);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DuesExists(int id)
        {
            return _context.Dues.Any(e => e.DuesID == id);
        }
    }
}
