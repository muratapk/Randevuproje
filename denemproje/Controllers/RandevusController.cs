using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using denemproje.Data;
using denemproje.Models;

namespace denemproje.Controllers
{
    public class RandevusController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RandevusController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Randevus
        public async Task<IActionResult> Index()
        {
              return _context.Randevus != null ? 
                          View(await _context.Randevus.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.Randevus'  is null.");
        }

        // GET: Randevus/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Randevus == null)
            {
                return NotFound();
            }

            var randevu = await _context.Randevus
                .FirstOrDefaultAsync(m => m.Id == id);
            if (randevu == null)
            {
                return NotFound();
            }

            return View(randevu);
        }

        // GET: Randevus/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Randevus/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,AdiSoyadi,CepNo,RandevuSaati,YapilanIslem")] Randevu randevu)
        {
            if (ModelState.IsValid)
            {
                _context.Add(randevu);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(randevu);
        }

        // GET: Randevus/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Randevus == null)
            {
                return NotFound();
            }

            var randevu = await _context.Randevus.FindAsync(id);
            if (randevu == null)
            {
                return NotFound();
            }
            return View(randevu);
        }

        // POST: Randevus/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,AdiSoyadi,CepNo,RandevuSaati,YapilanIslem")] Randevu randevu)
        {
            if (id != randevu.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(randevu);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RandevuExists(randevu.Id))
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
            return View(randevu);
        }

        // GET: Randevus/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Randevus == null)
            {
                return NotFound();
            }

            var randevu = await _context.Randevus
                .FirstOrDefaultAsync(m => m.Id == id);
            if (randevu == null)
            {
                return NotFound();
            }

            return View(randevu);
        }

        // POST: Randevus/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Randevus == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Randevus'  is null.");
            }
            var randevu = await _context.Randevus.FindAsync(id);
            if (randevu != null)
            {
                _context.Randevus.Remove(randevu);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RandevuExists(int id)
        {
          return (_context.Randevus?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
