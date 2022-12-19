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
    public class NaturalGasBillsController : Controller
    {
        private readonly InvoiceManagementSystemContext _context;

        public NaturalGasBillsController(InvoiceManagementSystemContext context)
        {
            _context = context;
        }

        // GET: NaturalGasBills
        public async Task<IActionResult> Index()
        {
            var invoiceManagementSystemContext = _context.NaturalGasBills.Include(n => n.User);
            return View(await invoiceManagementSystemContext.ToListAsync());
        }

        // GET: NaturalGasBills/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var naturalGasBill = await _context.NaturalGasBills
                .Include(n => n.User)
                .FirstOrDefaultAsync(m => m.NaturalGasBillID == id);
            if (naturalGasBill == null)
            {
                return NotFound();
            }

            return View(naturalGasBill);
        }

        // GET: NaturalGasBills/Create
        public IActionResult Create()
        {
            ViewData["UserID"] = new SelectList(_context.Set<User>(), "UserId", "UserId");
            return View();
        }

        // POST: NaturalGasBills/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("NaturalGasBillID,NaturalGasBillSerialNumber,NaturalGasBillSequenceNo,NaturalGasBillCompanyName,NaturalGasBillPrice,NaturalGasBillDate,NaturalGasBilllDescription,NaturalGasBillStatus,UserID")] NaturalGasBill naturalGasBill)
        {
            if (ModelState.IsValid)
            {
                _context.Add(naturalGasBill);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["UserID"] = new SelectList(_context.Set<User>(), "UserId", "UserId", naturalGasBill.UserID);
            return View(naturalGasBill);
        }
        [HttpGet]
        public IActionResult CreateBatch()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateBatch([Bind("NaturalGasBillSerialNumber,NaturalGasBillSequenceNo,NaturalGasBillCompanyName,NaturalGasBillPrice,NaturalGasBillDate,NaturalGasBilllDescription,NaturalGasBillStatus")] NaturalGasBill naturalGasBill)
        {
            if (ModelState.IsValid)
            {
                var userList = await _context.Users.ToListAsync();
                var naturalGasBillList = new List<NaturalGasBill>();
                foreach (var user in userList)
                {
                    naturalGasBillList.Add(new NaturalGasBill { NaturalGasBillSerialNumber = naturalGasBill.NaturalGasBillSerialNumber, NaturalGasBillSequenceNo = naturalGasBill.NaturalGasBillSequenceNo, NaturalGasBillCompanyName = naturalGasBill.NaturalGasBillCompanyName, NaturalGasBillPrice = naturalGasBill.NaturalGasBillPrice, NaturalGasBillDate = naturalGasBill.NaturalGasBillDate, NaturalGasBilllDescription = naturalGasBill.NaturalGasBilllDescription, NaturalGasBillStatus = naturalGasBill.NaturalGasBillStatus, UserID = user.UserId });
                }
                await _context.NaturalGasBills.AddRangeAsync(naturalGasBillList);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }

            return View();
        }
        // GET: NaturalGasBills/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var naturalGasBill = await _context.NaturalGasBills.FindAsync(id);
            if (naturalGasBill == null)
            {
                return NotFound();
            }
            ViewData["UserID"] = new SelectList(_context.Set<User>(), "UserId", "UserId", naturalGasBill.UserID);
            return View(naturalGasBill);
        }

        // POST: NaturalGasBills/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("NaturalGasBillID,NaturalGasBillSerialNumber,NaturalGasBillSequenceNo,NaturalGasBillCompanyName,NaturalGasBillPrice,NaturalGasBillDate,NaturalGasBilllDescription,NaturalGasBillStatus,UserID")] NaturalGasBill naturalGasBill)
        {
            if (id != naturalGasBill.NaturalGasBillID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(naturalGasBill);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NaturalGasBillExists(naturalGasBill.NaturalGasBillID))
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
            ViewData["UserID"] = new SelectList(_context.Set<User>(), "UserId", "UserId", naturalGasBill.UserID);
            return View(naturalGasBill);
        }

        // GET: NaturalGasBills/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var naturalGasBill = await _context.NaturalGasBills
                .Include(n => n.User)
                .FirstOrDefaultAsync(m => m.NaturalGasBillID == id);
            if (naturalGasBill == null)
            {
                return NotFound();
            }

            return View(naturalGasBill);
        }

        // POST: NaturalGasBills/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var naturalGasBill = await _context.NaturalGasBills.FindAsync(id);
            _context.NaturalGasBills.Remove(naturalGasBill);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NaturalGasBillExists(int id)
        {
            return _context.NaturalGasBills.Any(e => e.NaturalGasBillID == id);
        }
    }
}
