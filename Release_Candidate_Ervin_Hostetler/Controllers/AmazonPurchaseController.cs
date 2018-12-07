using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Release_Candidate_Ervin_Hostetler.Models;

namespace Release_Candidate_Ervin_Hostetler.Controllers
{
    public class AmazonPurchaseController : Controller
    {
        private readonly Release_Candidate_Ervin_HostetlerContext _context;

        public AmazonPurchaseController(Release_Candidate_Ervin_HostetlerContext context)
        {
            _context = context;
        }

        // GET: AmazonPurchase
        public async Task<IActionResult> Index()
        {
            return View(await _context.AmazonPurchase.ToListAsync());
        }

        // GET: AmazonPurchase/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var amazonPurchase = await _context.AmazonPurchase
                .FirstOrDefaultAsync(m => m.AmazonPurchaseId == id);
            if (amazonPurchase == null)
            {
                return NotFound();
            }

            return View(amazonPurchase);
        }

        // GET: AmazonPurchase/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AmazonPurchase/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AmazonPurchaseId,Quantity,Description,PurchasePrice,URL,ShippingCost")] AmazonPurchase amazonPurchase)
        {
            if (ModelState.IsValid)
            {
                _context.Add(amazonPurchase);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(amazonPurchase);
        }

        // GET: AmazonPurchase/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var amazonPurchase = await _context.AmazonPurchase.FindAsync(id);
            if (amazonPurchase == null)
            {
                return NotFound();
            }
            return View(amazonPurchase);
        }

        // POST: AmazonPurchase/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AmazonPurchaseId,Quantity,Description,PurchasePrice,URL,ShippingCost")] AmazonPurchase amazonPurchase)
        {
            if (id != amazonPurchase.AmazonPurchaseId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(amazonPurchase);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AmazonPurchaseExists(amazonPurchase.AmazonPurchaseId))
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
            return View(amazonPurchase);
        }

        // GET: AmazonPurchase/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var amazonPurchase = await _context.AmazonPurchase
                .FirstOrDefaultAsync(m => m.AmazonPurchaseId == id);
            if (amazonPurchase == null)
            {
                return NotFound();
            }

            return View(amazonPurchase);
        }

        // POST: AmazonPurchase/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var amazonPurchase = await _context.AmazonPurchase.FindAsync(id);
            _context.AmazonPurchase.Remove(amazonPurchase);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AmazonPurchaseExists(int id)
        {
            return _context.AmazonPurchase.Any(e => e.AmazonPurchaseId == id);
        }
    }
}
