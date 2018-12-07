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
    public class LaborController : Controller
    {
        private readonly Release_Candidate_Ervin_HostetlerContext _context;

        public LaborController(Release_Candidate_Ervin_HostetlerContext context)
        {
            _context = context;
        }

        // GET: Labor
        public async Task<IActionResult> Index()
        {
            return View(await _context.Labor.ToListAsync());
        }

        // GET: Labor/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var labor = await _context.Labor
                .FirstOrDefaultAsync(m => m.LaborId == id);
            if (labor == null)
            {
                return NotFound();
            }

            return View(labor);
        }

        // GET: Labor/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Labor/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("LaborId,Quantity,Description,LaborCost")] Labor labor)
        {
            if (ModelState.IsValid)
            {
                _context.Add(labor);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(labor);
        }

        // GET: Labor/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var labor = await _context.Labor.FindAsync(id);
            if (labor == null)
            {
                return NotFound();
            }
            return View(labor);
        }

        // POST: Labor/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("LaborId,Quantity,Description,LaborCost")] Labor labor)
        {
            if (id != labor.LaborId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(labor);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LaborExists(labor.LaborId))
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
            return View(labor);
        }

        // GET: Labor/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var labor = await _context.Labor
                .FirstOrDefaultAsync(m => m.LaborId == id);
            if (labor == null)
            {
                return NotFound();
            }

            return View(labor);
        }

        // POST: Labor/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var labor = await _context.Labor.FindAsync(id);
            _context.Labor.Remove(labor);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LaborExists(int id)
        {
            return _context.Labor.Any(e => e.LaborId == id);
        }
    }
}
