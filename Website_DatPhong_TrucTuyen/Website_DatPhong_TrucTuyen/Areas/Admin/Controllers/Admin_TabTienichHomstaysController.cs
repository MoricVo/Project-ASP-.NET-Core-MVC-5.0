using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Website_DatPhong_TrucTuyen.Models;

namespace Website_DatPhong_TrucTuyen.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class Admin_TabTienichHomstaysController : Controller
    {
        private readonly csdl_doan_congnghewebContext _context;

        public Admin_TabTienichHomstaysController(csdl_doan_congnghewebContext context)
        {
            _context = context;
        }

        // GET: Admin/Admin_TabTienichHomstays
        public async Task<IActionResult> Index()
        {
            return View(await _context.TabTienichHomstays.ToListAsync());
        }

        // GET: Admin/Admin_TabTienichHomstays/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tabTienichHomstay = await _context.TabTienichHomstays
                .FirstOrDefaultAsync(m => m.IdTienich == id);
            if (tabTienichHomstay == null)
            {
                return NotFound();
            }

            return View(tabTienichHomstay);
        }

        // GET: Admin/Admin_TabTienichHomstays/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/Admin_TabTienichHomstays/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdTienich,Tentienich,Giatien,Icon")] TabTienichHomstay tabTienichHomstay)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tabTienichHomstay);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tabTienichHomstay);
        }

        // GET: Admin/Admin_TabTienichHomstays/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tabTienichHomstay = await _context.TabTienichHomstays.FindAsync(id);
            if (tabTienichHomstay == null)
            {
                return NotFound();
            }
            return View(tabTienichHomstay);
        }

        // POST: Admin/Admin_TabTienichHomstays/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("IdTienich,Tentienich,Giatien,Icon")] TabTienichHomstay tabTienichHomstay)
        {
            if (id != tabTienichHomstay.IdTienich)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tabTienichHomstay);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TabTienichHomstayExists(tabTienichHomstay.IdTienich))
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
            return View(tabTienichHomstay);
        }

        // GET: Admin/Admin_TabTienichHomstays/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tabTienichHomstay = await _context.TabTienichHomstays
                .FirstOrDefaultAsync(m => m.IdTienich == id);
            if (tabTienichHomstay == null)
            {
                return NotFound();
            }

            return View(tabTienichHomstay);
        }

        // POST: Admin/Admin_TabTienichHomstays/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var tabTienichHomstay = await _context.TabTienichHomstays.FindAsync(id);
            _context.TabTienichHomstays.Remove(tabTienichHomstay);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TabTienichHomstayExists(string id)
        {
            return _context.TabTienichHomstays.Any(e => e.IdTienich == id);
        }
    }
}
