using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Website_DatPhong_TrucTuyen.Models;

namespace Website_DatPhong_TrucTuyen.Controllers
{
    public class Client_TabBaivietsController : Controller
    {
        private readonly csdl_doan_congnghewebContext _context;

        public Client_TabBaivietsController(csdl_doan_congnghewebContext context)
        {
            _context = context;
        }

        // GET: Client_TabBaiviets
        public async Task<IActionResult> Index()
        {
            var csdl_doan_congnghewebContext = _context.TabBaiviets.Include(t => t.IdChudeNavigation).Include(t => t.IdNguoidungNavigation);
            return View(await csdl_doan_congnghewebContext.ToListAsync());
        }

        // GET: Client_TabBaiviets/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tabBaiviet = await _context.TabBaiviets
                .Include(t => t.IdChudeNavigation)
                .Include(t => t.IdNguoidungNavigation)
                .FirstOrDefaultAsync(m => m.IdBaiviet == id);
            if (tabBaiviet == null)
            {
                return NotFound();
            }

            return View(tabBaiviet);
        }

        // GET: Client_TabBaiviets/Create
        public IActionResult Create()
        {
            ViewData["IdChude"] = new SelectList(_context.TabChudes, "IdChude", "IdChude");
            ViewData["IdNguoidung"] = new SelectList(_context.TabNguoidungs, "IdNguoidung", "IdNguoidung");
            return View();
        }

        // POST: Client_TabBaiviets/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdBaiviet,IdNguoidung,IdChude,Tieude,Noidung,Ghichu,Hinhanh,Ngaydang,Luotxem,Kiemduyet")] TabBaiviet tabBaiviet)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tabBaiviet);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdChude"] = new SelectList(_context.TabChudes, "IdChude", "IdChude", tabBaiviet.IdChude);
            ViewData["IdNguoidung"] = new SelectList(_context.TabNguoidungs, "IdNguoidung", "IdNguoidung", tabBaiviet.IdNguoidung);
            return View(tabBaiviet);
        }

        // GET: Client_TabBaiviets/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tabBaiviet = await _context.TabBaiviets.FindAsync(id);
            if (tabBaiviet == null)
            {
                return NotFound();
            }
            ViewData["IdChude"] = new SelectList(_context.TabChudes, "IdChude", "IdChude", tabBaiviet.IdChude);
            ViewData["IdNguoidung"] = new SelectList(_context.TabNguoidungs, "IdNguoidung", "IdNguoidung", tabBaiviet.IdNguoidung);
            return View(tabBaiviet);
        }

        // POST: Client_TabBaiviets/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("IdBaiviet,IdNguoidung,IdChude,Tieude,Noidung,Ghichu,Hinhanh,Ngaydang,Luotxem,Kiemduyet")] TabBaiviet tabBaiviet)
        {
            if (id != tabBaiviet.IdBaiviet)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tabBaiviet);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TabBaivietExists(tabBaiviet.IdBaiviet))
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
            ViewData["IdChude"] = new SelectList(_context.TabChudes, "IdChude", "IdChude", tabBaiviet.IdChude);
            ViewData["IdNguoidung"] = new SelectList(_context.TabNguoidungs, "IdNguoidung", "IdNguoidung", tabBaiviet.IdNguoidung);
            return View(tabBaiviet);
        }

        // GET: Client_TabBaiviets/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tabBaiviet = await _context.TabBaiviets
                .Include(t => t.IdChudeNavigation)
                .Include(t => t.IdNguoidungNavigation)
                .FirstOrDefaultAsync(m => m.IdBaiviet == id);
            if (tabBaiviet == null)
            {
                return NotFound();
            }

            return View(tabBaiviet);
        }

        // POST: Client_TabBaiviets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var tabBaiviet = await _context.TabBaiviets.FindAsync(id);
            _context.TabBaiviets.Remove(tabBaiviet);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TabBaivietExists(string id)
        {
            return _context.TabBaiviets.Any(e => e.IdBaiviet == id);
        }
    }
}
