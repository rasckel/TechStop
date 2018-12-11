using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Release_Candidate_Ervin_Hostetler.Models;
//using static Release_Candidate_Ervin_Hostetler.Controllers.QueryOptionsController;

namespace Release_Candidate_Ervin_Hostetler.Controllers
{
    public class QuoteController : Controller
    {
        private readonly Release_Candidate_Ervin_HostetlerContext _context;

        public QuoteController(Release_Candidate_Ervin_HostetlerContext context)
        {
            _context = context;
        }

        // GET: Quote
        public async Task<IActionResult> Index()
        {
            return View(await _context.Quote.ToListAsync());
        }

        // GET: Quote/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var quote = await _context.Quote
                .FirstOrDefaultAsync(m => m.QuoteID == id);
            if (quote == null)
            {
                return NotFound();
            }

            return View(quote);
        }

        // GET: Quote/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Quote/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("QuoteID,Name,TicketNumber,LaborQuantity,LaborDescription,LaborCost,PurchaseQuantity,PurchaseDescription,PurchasePrice,PurchaseURL,PurchaseShippingCost,URL,ShippingCost,Type,Date,Reason,SubTotal,Tax,Total")] Quote quote)
        {
            if (ModelState.IsValid)
            {
                _context.Add(quote);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(quote);
        }

        // GET: Quote/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var quote = await _context.Quote.FindAsync(id);
            if (quote == null)
            {
                return NotFound();
            }
            return View(quote);
        }

        // POST: Quote/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("QuoteID,Name,TicketNumber,LaborQuantity,LaborDescription,LaborCost,PurchaseQuantity,PurchaseDescription,PurchasePrice,PurchaseURL,PurchaseShippingCost,URL,ShippingCost,Type,Date,Reason,SubTotal,Tax,Total")] Quote quote)
        {
            if (id != quote.QuoteID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(quote);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!QuoteExists(quote.QuoteID))
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
            return View(quote);
        }

        // GET: Quote/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var quote = await _context.Quote
                .FirstOrDefaultAsync(m => m.QuoteID == id);
            if (quote == null)
            {
                return NotFound();
            }

            return View(quote);
        }

        // POST: Quote/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var quote = await _context.Quote.FindAsync(id);
            _context.Quote.Remove(quote);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool QuoteExists(int id)
        {
            return _context.Quote.Any(e => e.QuoteID == id);
        }

        //public async Task<IActionResult> Report(QueryOptions queryOptions)
        //{
        //    if (queryOptions == null || string.IsNullOrWhiteSpace(queryOptions.SortField))
        //    {
        //        queryOptions = new QueryOptions
        //        {
        //            SortField = "LastName",
        //            SortOrder = SortOrder.ASC
        //        };
        //    }
        //    ViewBag.QueryOptions = queryOptions;
        //    return View(await _context..OrderBy(queryOptions.Sort).ToListAsync());
        //}

    }
}
