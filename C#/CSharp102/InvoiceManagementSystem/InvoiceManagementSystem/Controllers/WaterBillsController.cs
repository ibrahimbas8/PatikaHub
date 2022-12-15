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
    public class WaterBillsController : Controller
    {
        private readonly InvoiceManagementSystemContext _context;

        public WaterBillsController(InvoiceManagementSystemContext context)
        {
            _context = context;
        }

        // GET: WaterBills
        public async Task<IActionResult> Index()
        {
            var invoiceManagementSystemContext = _context.WaterBills.Include(w => w.User);
            return View(await invoiceManagementSystemContext.ToListAsync());
        }

        // GET: WaterBills/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var waterBill = await _context.WaterBills
                .Include(w => w.User)
                .FirstOrDefaultAsync(m => m.WaterBillID == id);
            if (waterBill == null)
            {
                return NotFound();
            }

            return View(waterBill);
        }

        // GET: WaterBills/Create
        public IActionResult Create()
        {
            ViewData["UserID"] = new SelectList(_context.Users, "UserId", "UserId");
            return View();
        }

        // POST: WaterBills/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("WaterBillID,WaterBillSerialNumber,WaterBillSequenceNo,WaterBillCompanyName,WaterBillPrice,WaterBillDate,WaterBillDescription,WaterBillStatus,UserID")] WaterBill waterBill)
        {
            if (ModelState.IsValid)
            {
                _context.Add(waterBill);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["UserID"] = new SelectList(_context.Users, "UserId", "UserId", waterBill.UserID);
            return View(waterBill);
        }

        // GET: WaterBills/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var waterBill = await _context.WaterBills.FindAsync(id);
            if (waterBill == null)
            {
                return NotFound();
            }
            ViewData["UserID"] = new SelectList(_context.Users, "UserId", "UserId", waterBill.UserID);
            return View(waterBill);
        }

        // POST: WaterBills/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("WaterBillID,WaterBillSerialNumber,WaterBillSequenceNo,WaterBillCompanyName,WaterBillPrice,WaterBillDate,WaterBillDescription,WaterBillStatus,UserID")] WaterBill waterBill)
        {
            if (id != waterBill.WaterBillID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(waterBill);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!WaterBillExists(waterBill.WaterBillID))
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
            ViewData["UserID"] = new SelectList(_context.Users, "UserId", "UserId", waterBill.UserID);
            return View(waterBill);
        }

        // GET: WaterBills/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var waterBill = await _context.WaterBills
                .Include(w => w.User)
                .FirstOrDefaultAsync(m => m.WaterBillID == id);
            if (waterBill == null)
            {
                return NotFound();
            }

            return View(waterBill);
        }

        // POST: WaterBills/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var waterBill = await _context.WaterBills.FindAsync(id);
            _context.WaterBills.Remove(waterBill);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool WaterBillExists(int id)
        {
            return _context.WaterBills.Any(e => e.WaterBillID == id);
        }
    }
}
