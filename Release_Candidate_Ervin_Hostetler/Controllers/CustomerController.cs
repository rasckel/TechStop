using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Release_Candidate_Ervin_Hostetler.Models;
using Release_Candidate_Ervin_Hostetler.ViewModel;

namespace Release_Candidate_Ervin_Hostetler.Controllers
{
    public class CustomerController : Controller 
    {
        private readonly Release_Candidate_Ervin_HostetlerContext _context;

        public CustomerController(Release_Candidate_Ervin_HostetlerContext context)
        {
            _context = context;
        }

        // GET: Customer
        public async Task<IActionResult> Index()
        {
            return View(await _context.Customer.ToListAsync());
        }

        // GET: Customer/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer = await _context.Customer
                .FirstOrDefaultAsync(m => m.CustomerId == id);
            if (customer == null)
            {
                return NotFound();
            }

            return View(customer);
        }

        // GET: Customer/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Customer/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CustomerId,Name,TicketNumber,PurcahseQuanity,PurcahseDescription,PurchasePrice,URL,ShippingCost,LaborQuantity,LaborDescription,LaborCost")] QuoteViewModel quote)
        {
            var customer = new Customer
            {
                Name = quote.Name,
            };

            var purchase = new Purchase
            {
                PurchaseQuantity = quote.PurchaseQuantity,
                PurchaseDescription = quote.PurchaseDescription,
                PurchasePrice = quote.PurchasePrice,
                URL = quote.URL,
                ShippingCost = quote.ShippingCost
            };

            var labor = new Labor
            {
                LaborQuantity = quote.LaborQuantity,
                LaborDescription = quote.LaborDescription,
                LaborCost = quote.LaborCost
            };

            var quoteData = new Quote
            {
                Customer = customer,
                Purchase = purchase,
                Labor = labor
            };

            /*var quote = new Quote 
            {
               Name = Quote.Name,
               TicketNumber = Quote.TicketNumber,
               PurchaseQuantity = Quote.PurchaseQuantity,
               PurchaseDescription = Quote.PurchaseDescription,
               PurchasePrice = Quote.PurchasePrice,
               URL = Quote.URL,
               ShippingCost = Quote.ShippingCost,
               LaborQuantity = Quote.LaborQuantity,
               LaborDescription = Quote.LaborDescription,
               LaborCost = Quote.LaborCost
            };*/

            if (ModelState.IsValid)
            {
                _context.Add(customer);
                _context.Add(labor);
                _context.Add(purchase);
                _context.Add(quoteData);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Quote));
            }
            return View(quote);
        }

         //GET: Customer/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer = await _context.Customer.FindAsync(id);
            if (customer == null)
            {
                return NotFound();
            }
            return View(customer);
        }

        // POST: Customer/Edit/5
         //To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CustomerId,Name,TicketNumber")] Customer customer)
        {
            if (id != customer.CustomerId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(customer);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CustomerExists(customer.CustomerId))
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
            return View(customer);
        }

         //GET: Customer/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer = await _context.Customer
                .FirstOrDefaultAsync(m => m.CustomerId == id);
            if (customer == null)
            {
                return NotFound();
            }

            return View(customer);
        }

         //POST: Customer/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var customer = await _context.Customer.FindAsync(id);
            _context.Customer.Remove(customer);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CustomerExists(int id)
        {
            return _context.Customer.Any(e => e.CustomerId == id);
        }

    

    }
}
