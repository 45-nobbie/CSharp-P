using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PostgresDB.Data;
using PostgresDB.Models;

namespace PostgresDB.Controllers
{
    public class ConPgsController : Controller
    {
        private readonly MyDbContext _context;

        public ConPgsController(MyDbContext context)
        {
            _context = context;
        }

        // GET: ConPgs
        public async Task<IActionResult> Index()
        {
              return _context.MyModels != null ? 
                          View(await _context.MyModels.ToListAsync()) :
                          Problem("Entity set 'MyDbContext.MyModels'  is null.");
        }

        // GET: ConPgs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.MyModels == null)
            {
                return NotFound();
            }

            var conPg = await _context.MyModels
                .FirstOrDefaultAsync(m => m.Id == id);
            if (conPg == null)
            {
                return NotFound();
            }

            return View(conPg);
        }

        // GET: ConPgs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ConPgs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name")] ConPg conPg)
        {
            if (ModelState.IsValid)
            {
                _context.Add(conPg);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(conPg);
        }

        // GET: ConPgs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.MyModels == null)
            {
                return NotFound();
            }

            var conPg = await _context.MyModels.FindAsync(id);
            if (conPg == null)
            {
                return NotFound();
            }
            return View(conPg);
        }

        // POST: ConPgs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name")] ConPg conPg)
        {
            if (id != conPg.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(conPg);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ConPgExists(conPg.Id))
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
            return View(conPg);
        }

        // GET: ConPgs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.MyModels == null)
            {
                return NotFound();
            }

            var conPg = await _context.MyModels
                .FirstOrDefaultAsync(m => m.Id == id);
            if (conPg == null)
            {
                return NotFound();
            }

            return View(conPg);
        }

        // POST: ConPgs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.MyModels == null)
            {
                return Problem("Entity set 'MyDbContext.MyModels'  is null.");
            }
            var conPg = await _context.MyModels.FindAsync(id);
            if (conPg != null)
            {
                _context.MyModels.Remove(conPg);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ConPgExists(int id)
        {
          return (_context.MyModels?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
