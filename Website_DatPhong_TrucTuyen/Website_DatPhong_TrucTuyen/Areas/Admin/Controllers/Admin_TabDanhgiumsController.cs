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
    public class Admin_TabDanhgiumsController : Controller
    {
        private readonly csdl_doan_congnghewebContext _context;

        public Admin_TabDanhgiumsController(csdl_doan_congnghewebContext context)
        {
            _context = context;
        }

        // GET: Admin/Admin_TabDanhgiums
        public async Task<IActionResult> Index()
        {
            var csdl_doan_congnghewebContext = _context.TabDanhgia.Include(t => t.IdHomestayNavigation).Include(t => t.IdNguoidungNavigation);
            return View(await csdl_doan_congnghewebContext.ToListAsync());
        }

        // GET: Admin/Admin_TabDanhgiums/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tabDanhgium = await _context.TabDanhgia
                .Include(t => t.IdHomestayNavigation)
                .Include(t => t.IdNguoidungNavigation)
                .FirstOrDefaultAsync(m => m.IdDanhgia == id);
            if (tabDanhgium == null)
            {
                return NotFound();
            }

            return View(tabDanhgium);
        }

        // GET: Admin/Admin_TabDanhgiums/Create
        public IActionResult Create()
        {
            ViewData["IdHomestay"] = new SelectList(_context.TabHomestays, "IdHomstay", "IdHomstay");
            ViewData["IdNguoidung"] = new SelectList(_context.TabNguoidungs, "IdNguoidung", "IdNguoidung");
            return View();
        }

        // POST: Admin/Admin_TabDanhgiums/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdDanhgia,IdHomestay,IdNguoidung,Noidung,Diem,Ngaydang")] TabDanhgium tabDanhgium)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tabDanhgium);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdHomestay"] = new SelectList(_context.TabHomestays, "IdHomstay", "IdHomstay", tabDanhgium.IdHomestay);
            ViewData["IdNguoidung"] = new SelectList(_context.TabNguoidungs, "IdNguoidung", "IdNguoidung", tabDanhgium.IdNguoidung);
            return View(tabDanhgium);
        }

        // GET: Admin/Admin_TabDanhgiums/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tabDanhgium = await _context.TabDanhgia.FindAsync(id);
            if (tabDanhgium == null)
            {
                return NotFound();
            }
            ViewData["IdHomestay"] = new SelectList(_context.TabHomestays, "IdHomstay", "IdHomstay", tabDanhgium.IdHomestay);
            ViewData["IdNguoidung"] = new SelectList(_context.TabNguoidungs, "IdNguoidung", "IdNguoidung", tabDanhgium.IdNguoidung);
            return View(tabDanhgium);
        }

        // POST: Admin/Admin_TabDanhgiums/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("IdDanhgia,IdHomestay,IdNguoidung,Noidung,Diem,Ngaydang")] TabDanhgium tabDanhgium)
        {
            if (id != tabDanhgium.IdDanhgia)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tabDanhgium);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TabDanhgiumExists(tabDanhgium.IdDanhgia))
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
            ViewData["IdHomestay"] = new SelectList(_context.TabHomestays, "IdHomstay", "IdHomstay", tabDanhgium.IdHomestay);
            ViewData["IdNguoidung"] = new SelectList(_context.TabNguoidungs, "IdNguoidung", "IdNguoidung", tabDanhgium.IdNguoidung);
            return View(tabDanhgium);
        }

        // GET: Admin/Admin_TabDanhgiums/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tabDanhgium = await _context.TabDanhgia
                .Include(t => t.IdHomestayNavigation)
                .Include(t => t.IdNguoidungNavigation)
                .FirstOrDefaultAsync(m => m.IdDanhgia == id);
            if (tabDanhgium == null)
            {
                return NotFound();
            }

            return View(tabDanhgium);
        }

        // POST: Admin/Admin_TabDanhgiums/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var tabDanhgium = await _context.TabDanhgia.FindAsync(id);
            _context.TabDanhgia.Remove(tabDanhgium);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TabDanhgiumExists(string id)
        {
            return _context.TabDanhgia.Any(e => e.IdDanhgia == id);
        }
    }
}
