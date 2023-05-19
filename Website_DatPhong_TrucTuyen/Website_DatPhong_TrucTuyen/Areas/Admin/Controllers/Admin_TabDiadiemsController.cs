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
    public class Admin_TabDiadiemsController : Controller
    {
        private readonly csdl_doan_congnghewebContext _context;

        public Admin_TabDiadiemsController(csdl_doan_congnghewebContext context)
        {
            _context = context;
        }

        // GET: Admin/Admin_TabDiadiems
        public async Task<IActionResult> Index()
        {
            var csdl_doan_congnghewebContext = _context.TabDiadiems.Include(t => t.IdNguoidungNavigation);
            return View(await csdl_doan_congnghewebContext.ToListAsync());
        }

        // GET: Admin/Admin_TabDiadiems/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tabDiadiem = await _context.TabDiadiems
                .Include(t => t.IdNguoidungNavigation)
                .FirstOrDefaultAsync(m => m.IdDiadiem == id);
            if (tabDiadiem == null)
            {
                return NotFound();
            }

            return View(tabDiadiem);
        }

        // GET: Admin/Admin_TabDiadiems/Create
        public IActionResult Create()
        {
            ViewData["IdNguoidung"] = new SelectList(_context.TabNguoidungs, "IdNguoidung", "IdNguoidung");
            return View();
        }

        // POST: Admin/Admin_TabDiadiems/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdDiadiem,IdNguoidung,Tendiadiem,Hinhanh,SlTours,Ngaydang")] TabDiadiem tabDiadiem)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tabDiadiem);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdNguoidung"] = new SelectList(_context.TabNguoidungs, "IdNguoidung", "IdNguoidung", tabDiadiem.IdNguoidung);
            return View(tabDiadiem);
        }

        // GET: Admin/Admin_TabDiadiems/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tabDiadiem = await _context.TabDiadiems.FindAsync(id);
            if (tabDiadiem == null)
            {
                return NotFound();
            }
            ViewData["IdNguoidung"] = new SelectList(_context.TabNguoidungs, "IdNguoidung", "IdNguoidung", tabDiadiem.IdNguoidung);
            return View(tabDiadiem);
        }

        // POST: Admin/Admin_TabDiadiems/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdDiadiem,IdNguoidung,Tendiadiem,Hinhanh,SlTours,Ngaydang")] TabDiadiem tabDiadiem)
        {
            if (id != tabDiadiem.IdDiadiem)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tabDiadiem);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TabDiadiemExists(tabDiadiem.IdDiadiem))
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
            ViewData["IdNguoidung"] = new SelectList(_context.TabNguoidungs, "IdNguoidung", "IdNguoidung", tabDiadiem.IdNguoidung);
            return View(tabDiadiem);
        }

        // GET: Admin/Admin_TabDiadiems/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tabDiadiem = await _context.TabDiadiems
                .Include(t => t.IdNguoidungNavigation)
                .FirstOrDefaultAsync(m => m.IdDiadiem == id);
            if (tabDiadiem == null)
            {
                return NotFound();
            }

            return View(tabDiadiem);
        }

        // POST: Admin/Admin_TabDiadiems/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var tabDiadiem = await _context.TabDiadiems.FindAsync(id);
            _context.TabDiadiems.Remove(tabDiadiem);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TabDiadiemExists(int id)
        {
            return _context.TabDiadiems.Any(e => e.IdDiadiem == id);
        }
    }
}
