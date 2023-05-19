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
    public class Admin_TabGioithieuxController : Controller
    {
        private readonly csdl_doan_congnghewebContext _context;

        public Admin_TabGioithieuxController(csdl_doan_congnghewebContext context)
        {
            _context = context;
        }

        // GET: Admin/Admin_TabGioithieux
        public async Task<IActionResult> Index()
        {
            var csdl_doan_congnghewebContext = _context.TabGioithieus.Include(t => t.IdNguoidungNavigation);
            return View(await csdl_doan_congnghewebContext.ToListAsync());
        }

        // GET: Admin/Admin_TabGioithieux/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tabGioithieu = await _context.TabGioithieus
                .Include(t => t.IdNguoidungNavigation)
                .FirstOrDefaultAsync(m => m.IdGioithieu == id);
            if (tabGioithieu == null)
            {
                return NotFound();
            }

            return View(tabGioithieu);
        }

        // GET: Admin/Admin_TabGioithieux/Create
        public IActionResult Create()
        {
            ViewData["IdNguoidung"] = new SelectList(_context.TabNguoidungs, "IdNguoidung", "IdNguoidung");
            return View();
        }

        // POST: Admin/Admin_TabGioithieux/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdGioithieu,IdNguoidung,Tieude,Noidung,Icon,Hinhanh")] TabGioithieu tabGioithieu)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tabGioithieu);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdNguoidung"] = new SelectList(_context.TabNguoidungs, "IdNguoidung", "IdNguoidung", tabGioithieu.IdNguoidung);
            return View(tabGioithieu);
        }

        // GET: Admin/Admin_TabGioithieux/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tabGioithieu = await _context.TabGioithieus.FindAsync(id);
            if (tabGioithieu == null)
            {
                return NotFound();
            }
            ViewData["IdNguoidung"] = new SelectList(_context.TabNguoidungs, "IdNguoidung", "IdNguoidung", tabGioithieu.IdNguoidung);
            return View(tabGioithieu);
        }

        // POST: Admin/Admin_TabGioithieux/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("IdGioithieu,IdNguoidung,Tieude,Noidung,Icon,Hinhanh")] TabGioithieu tabGioithieu)
        {
            if (id != tabGioithieu.IdGioithieu)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tabGioithieu);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TabGioithieuExists(tabGioithieu.IdGioithieu))
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
            ViewData["IdNguoidung"] = new SelectList(_context.TabNguoidungs, "IdNguoidung", "IdNguoidung", tabGioithieu.IdNguoidung);
            return View(tabGioithieu);
        }

        // GET: Admin/Admin_TabGioithieux/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tabGioithieu = await _context.TabGioithieus
                .Include(t => t.IdNguoidungNavigation)
                .FirstOrDefaultAsync(m => m.IdGioithieu == id);
            if (tabGioithieu == null)
            {
                return NotFound();
            }

            return View(tabGioithieu);
        }

        // POST: Admin/Admin_TabGioithieux/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var tabGioithieu = await _context.TabGioithieus.FindAsync(id);
            _context.TabGioithieus.Remove(tabGioithieu);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TabGioithieuExists(string id)
        {
            return _context.TabGioithieus.Any(e => e.IdGioithieu == id);
        }
    }
}
