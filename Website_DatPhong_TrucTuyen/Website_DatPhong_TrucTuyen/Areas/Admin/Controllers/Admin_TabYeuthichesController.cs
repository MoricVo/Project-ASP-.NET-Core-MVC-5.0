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
    public class Admin_TabYeuthichesController : Controller
    {
        private readonly csdl_doan_congnghewebContext _context;

        public Admin_TabYeuthichesController(csdl_doan_congnghewebContext context)
        {
            _context = context;
        }

        // GET: Admin/Admin_TabYeuthiches
        public async Task<IActionResult> Index()
        {
            var csdl_doan_congnghewebContext = _context.TabYeuthiches.Include(t => t.IdNguoidungNavigation);
            return View(await csdl_doan_congnghewebContext.ToListAsync());
        }

        // GET: Admin/Admin_TabYeuthiches/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tabYeuthich = await _context.TabYeuthiches
                .Include(t => t.IdNguoidungNavigation)
                .FirstOrDefaultAsync(m => m.IdYeuthich == id);
            if (tabYeuthich == null)
            {
                return NotFound();
            }

            return View(tabYeuthich);
        }

        // GET: Admin/Admin_TabYeuthiches/Create
        public IActionResult Create()
        {
            ViewData["IdNguoidung"] = new SelectList(_context.TabNguoidungs, "IdNguoidung", "IdNguoidung");
            return View();
        }

        // POST: Admin/Admin_TabYeuthiches/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdYeuthich,IdNguoidung,IdHomestay,Ghichu")] TabYeuthich tabYeuthich)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tabYeuthich);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdNguoidung"] = new SelectList(_context.TabNguoidungs, "IdNguoidung", "IdNguoidung", tabYeuthich.IdNguoidung);
            return View(tabYeuthich);
        }

        // GET: Admin/Admin_TabYeuthiches/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tabYeuthich = await _context.TabYeuthiches.FindAsync(id);
            if (tabYeuthich == null)
            {
                return NotFound();
            }
            ViewData["IdNguoidung"] = new SelectList(_context.TabNguoidungs, "IdNguoidung", "IdNguoidung", tabYeuthich.IdNguoidung);
            return View(tabYeuthich);
        }

        // POST: Admin/Admin_TabYeuthiches/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("IdYeuthich,IdNguoidung,IdHomestay,Ghichu")] TabYeuthich tabYeuthich)
        {
            if (id != tabYeuthich.IdYeuthich)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tabYeuthich);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TabYeuthichExists(tabYeuthich.IdYeuthich))
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
            ViewData["IdNguoidung"] = new SelectList(_context.TabNguoidungs, "IdNguoidung", "IdNguoidung", tabYeuthich.IdNguoidung);
            return View(tabYeuthich);
        }

        // GET: Admin/Admin_TabYeuthiches/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tabYeuthich = await _context.TabYeuthiches
                .Include(t => t.IdNguoidungNavigation)
                .FirstOrDefaultAsync(m => m.IdYeuthich == id);
            if (tabYeuthich == null)
            {
                return NotFound();
            }

            return View(tabYeuthich);
        }

        // POST: Admin/Admin_TabYeuthiches/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var tabYeuthich = await _context.TabYeuthiches.FindAsync(id);
            _context.TabYeuthiches.Remove(tabYeuthich);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TabYeuthichExists(string id)
        {
            return _context.TabYeuthiches.Any(e => e.IdYeuthich == id);
        }
    }
}
