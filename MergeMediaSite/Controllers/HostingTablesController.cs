using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MergeMediaSite.Models;

namespace MergeMediaSite.Controllers
{
    public class HostingTablesController : Controller
    {
        private readonly ClassContext _context;

        public HostingTablesController(ClassContext context)
        {
            _context = context;
        }

        // GET: HostingTables
        public async Task<IActionResult> Index()
        {
            return View(await _context.HostingTables.ToListAsync());
        }

        // GET: HostingTables/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hostingTable = await _context.HostingTables
                .SingleOrDefaultAsync(m => m.Id == id);
            if (hostingTable == null)
            {
                return NotFound();
            }

            return View(hostingTable);
        }

        // GET: HostingTables/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: HostingTables/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Instance,Cores,Ram,Storage,Prices")] HostingTable hostingTable)
        {
            if (ModelState.IsValid)
            {
                _context.Add(hostingTable);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(hostingTable);
        }

        // GET: HostingTables/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hostingTable = await _context.HostingTables.SingleOrDefaultAsync(m => m.Id == id);
            if (hostingTable == null)
            {
                return NotFound();
            }
            return View(hostingTable);
        }

        // POST: HostingTables/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Instance,Cores,Ram,Storage,Prices")] HostingTable hostingTable)
        {
            if (id != hostingTable.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(hostingTable);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HostingTableExists(hostingTable.Id))
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
            return View(hostingTable);
        }

        // GET: HostingTables/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hostingTable = await _context.HostingTables
                .SingleOrDefaultAsync(m => m.Id == id);
            if (hostingTable == null)
            {
                return NotFound();
            }

            return View(hostingTable);
        }

        // POST: HostingTables/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var hostingTable = await _context.HostingTables.SingleOrDefaultAsync(m => m.Id == id);
            _context.HostingTables.Remove(hostingTable);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HostingTableExists(int id)
        {
            return _context.HostingTables.Any(e => e.Id == id);
        }
    }
}
