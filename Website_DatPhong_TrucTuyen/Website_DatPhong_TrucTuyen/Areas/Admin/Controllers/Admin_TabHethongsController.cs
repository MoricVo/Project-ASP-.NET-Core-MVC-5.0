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
    public class Admin_TabHethongsController : Controller
    {
        private readonly csdl_doan_congnghewebContext _context;

        public Admin_TabHethongsController(csdl_doan_congnghewebContext context)
        {
            _context = context;
        }

        // GET: Admin/Admin_TabHethongs
        public async Task<IActionResult> Index()
        {
            return View(await _context.TabHethongs.ToListAsync());
        }

        // GET: Admin/Admin_TabHethongs/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tabHethong = await _context.TabHethongs
                .FirstOrDefaultAsync(m => m.IdHethong == id);
            if (tabHethong == null)
            {
                return NotFound();
            }

            return View(tabHethong);
        }

        // GET: Admin/Admin_TabHethongs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/Admin_TabHethongs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdHethong,Tieude,Noidung,Ghichu,Hinhanh")] TabHethong tabHethong)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tabHethong);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tabHethong);
        }

        // GET: Admin/Admin_TabHethongs/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tabHethong = await _context.TabHethongs.FindAsync(id);
            if (tabHethong == null)
            {
                return NotFound();
            }
            return View(tabHethong);
        }

        // POST: Admin/Admin_TabHethongs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("IdHethong,Tieude,Noidung,Ghichu,Hinhanh")] TabHethong tabHethong)
        {
            if (id != tabHethong.IdHethong)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tabHethong);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TabHethongExists(tabHethong.IdHethong))
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
            return View(tabHethong);
        }

        // GET: Admin/Admin_TabHethongs/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tabHethong = await _context.TabHethongs
                .FirstOrDefaultAsync(m => m.IdHethong == id);
            if (tabHethong == null)
            {
                return NotFound();
            }

            return View(tabHethong);
        }

        // POST: Admin/Admin_TabHethongs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var tabHethong = await _context.TabHethongs.FindAsync(id);
            _context.TabHethongs.Remove(tabHethong);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TabHethongExists(string id)
        {
            return _context.TabHethongs.Any(e => e.IdHethong == id);
        }
    }
}
