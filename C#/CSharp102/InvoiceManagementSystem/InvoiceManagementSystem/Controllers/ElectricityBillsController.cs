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
    public class ElectricityBillsController : Controller
    {
        private readonly InvoiceManagementSystemContext _context;

        public ElectricityBillsController(InvoiceManagementSystemContext context)
        {
            _context = context;
        }

        // GET: ElectricityBills
        public async Task<IActionResult> Index()
        {
            var invoiceManagementSystemContext = _context.ElectricityBills.Include(e => e.User);
            return View(await invoiceManagementSystemContext.ToListAsync());
        }

        // GET: ElectricityBills/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var electricityBill = await _context.ElectricityBills
                .Include(e => e.User)
                .FirstOrDefaultAsync(m => m.ElectricityBillID == id);
            if (electricityBill == null)
            {
                return NotFound();
            }

            return View(electricityBill);
        }

        // GET: ElectricityBills/Create
        public IActionResult Create()
        {
            ViewData["UserID"] = new SelectList(_context.Set<User>(), "UserId", "UserId");
            return View();
        }

        // POST: ElectricityBills/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ElectricityBillID,ElectricityBillSerialNumber,ElectricityBillSequenceNo,ElectricityBillCompanyName,ElectricityBillPrice,ElectricityBillDate,ElectricityBillDescription,ElectricityBillStatus,UserID")] ElectricityBill electricityBill)
        {
            if (ModelState.IsValid)
            {
                _context.Add(electricityBill);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["UserID"] = new SelectList(_context.Set<User>(), "UserId", "UserId", electricityBill.UserID);
            return View(electricityBill);
        }
        [HttpGet]
        public IActionResult CreateBatch()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateBatch([Bind("ElectricityBillSerialNumber,ElectricityBillSequenceNo,ElectricityBillCompanyName,ElectricityBillPrice,ElectricityBillDate,ElectricityBillDescription,ElectricityBillStatus")] ElectricityBill electricityBill)
        {
            if (ModelState.IsValid)
            {
                var userList = await _context.Users.ToListAsync();
                var electricityBillList = new List<ElectricityBill>();
                foreach (var user in userList)
                {
                    electricityBillList.Add(new ElectricityBill { ElectricityBillSerialNumber = electricityBill.ElectricityBillSerialNumber, ElectricityBillDate = electricityBill.ElectricityBillDate, ElectricityBillDescription = electricityBill.ElectricityBillDescription, ElectricityBillStatus = electricityBill.ElectricityBillStatus, ElectricityBillSequenceNo = electricityBill.ElectricityBillSequenceNo, ElectricityBillCompanyName = electricityBill.ElectricityBillCompanyName, ElectricityBillPrice = electricityBill.ElectricityBillPrice, UserID = user.UserId });
                }
                await _context.ElectricityBills.AddRangeAsync(electricityBillList);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }

            return View();
        }
        // GET: ElectricityBills/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var electricityBill = await _context.ElectricityBills.FindAsync(id);
            if (electricityBill == null)
            {
                return NotFound();
            }
            ViewData["UserID"] = new SelectList(_context.Set<User>(), "UserId", "UserId", electricityBill.UserID);
            return View(electricityBill);
        }

        // POST: ElectricityBills/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ElectricityBillID,ElectricityBillSerialNumber,ElectricityBillSequenceNo,ElectricityBillCompanyName,ElectricityBillPrice,ElectricityBillDate,ElectricityBillDescription,ElectricityBillStatus,UserID")] ElectricityBill electricityBill)
        {
            if (id != electricityBill.ElectricityBillID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(electricityBill);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ElectricityBillExists(electricityBill.ElectricityBillID))
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
            ViewData["UserID"] = new SelectList(_context.Set<User>(), "UserId", "UserId", electricityBill.UserID);
            return View(electricityBill);
        }

        // GET: ElectricityBills/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var electricityBill = await _context.ElectricityBills
                .Include(e => e.User)
                .FirstOrDefaultAsync(m => m.ElectricityBillID == id);
            if (electricityBill == null)
            {
                return NotFound();
            }

            return View(electricityBill);
        }

        // POST: ElectricityBills/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var electricityBill = await _context.ElectricityBills.FindAsync(id);
            _context.ElectricityBills.Remove(electricityBill);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ElectricityBillExists(int id)
        {
            return _context.ElectricityBills.Any(e => e.ElectricityBillID == id);
        }
    }
}
