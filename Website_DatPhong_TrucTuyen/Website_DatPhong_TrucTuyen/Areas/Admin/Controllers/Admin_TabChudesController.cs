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
    public class Admin_TabChudesController : Controller
    {
        private readonly csdl_doan_congnghewebContext _context;

        public Admin_TabChudesController(csdl_doan_congnghewebContext context)
        {
            _context = context;
        }

        // GET: Admin/Admin_TabChudes
        public async Task<IActionResult> Index()
        {
            return View(await _context.TabChudes.ToListAsync());
        }

        // GET: Admin/Admin_TabChudes/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tabChude = await _context.TabChudes
                .FirstOrDefaultAsync(m => m.IdChude == id);
            if (tabChude == null)
            {
                return NotFound();
            }

            return View(tabChude);
        }

        // GET: Admin/Admin_TabChudes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/Admin_TabChudes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdChude,Tenchude,Ghichu,Ngaydang")] TabChude tabChude)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tabChude);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tabChude);
        }

        // GET: Admin/Admin_TabChudes/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tabChude = await _context.TabChudes.FindAsync(id);
            if (tabChude == null)
            {
                return NotFound();
            }
            return View(tabChude);
        }

        // POST: Admin/Admin_TabChudes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("IdChude,Tenchude,Ghichu,Ngaydang")] TabChude tabChude)
        {
            if (id != tabChude.IdChude)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tabChude);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TabChudeExists(tabChude.IdChude))
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
            return View(tabChude);
        }

        // GET: Admin/Admin_TabChudes/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tabChude = await _context.TabChudes
                .FirstOrDefaultAsync(m => m.IdChude == id);
            if (tabChude == null)
            {
                return NotFound();
            }

            return View(tabChude);
        }

        // POST: Admin/Admin_TabChudes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var tabChude = await _context.TabChudes.FindAsync(id);
            _context.TabChudes.Remove(tabChude);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TabChudeExists(string id)
        {
            return _context.TabChudes.Any(e => e.IdChude == id);
        }
    }
}
