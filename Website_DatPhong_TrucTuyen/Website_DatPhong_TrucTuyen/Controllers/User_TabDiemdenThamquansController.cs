using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Website_DatPhong_TrucTuyen.Models;

namespace Website_DatPhong_TrucTuyen.Controllers
{
    public class User_TabDiemdenThamquansController : Controller
    {
        private readonly csdl_doan_congnghewebContext _context;

        public User_TabDiemdenThamquansController(csdl_doan_congnghewebContext context)
        {
            _context = context;
        }

        // GET: User_TabDiemdenThamquans
        public async Task<IActionResult> Index()
        {
            var csdl_doan_congnghewebContext = _context.TabDiemdenThamquans.Include(t => t.IdDiemdenNavigation).Include(t => t.IdNguoidungNavigation);
            return View(await csdl_doan_congnghewebContext.ToListAsync());
        }

        // GET: User_TabDiemdenThamquans/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tabDiemdenThamquan = await _context.TabDiemdenThamquans
                .Include(t => t.IdDiemdenNavigation)
                .Include(t => t.IdNguoidungNavigation)
                .FirstOrDefaultAsync(m => m.IdDiemdenThamquan == id);
            if (tabDiemdenThamquan == null)
            {
                return NotFound();
            }

            return View(tabDiemdenThamquan);
        }

        // GET: User_TabDiemdenThamquans/Create
        public IActionResult Create()
        {
            ViewData["IdDiemden"] = new SelectList(_context.TabDiadiems, "IdDiadiem", "Tendiadiem");
            ViewData["IdNguoidung"] = new SelectList(_context.TabNguoidungs, "IdNguoidung", "Tennguoidung");
            return View();
        }

        // POST: User_TabDiemdenThamquans/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(IFormFile file, [Bind("IdDiemdenThamquan,IdNguoidung,IdDiemden,Diachicuthe,Slngayo,Tendiadiemthamquan,Tienich,Tienich1,Tienich2,Tienich3,Tienich4,Giatien,Hinhanh,Hinhphu1,Hinhphu2,Hinhphu3,Hinhphu4,Noiquy1,Noiquy2,Noiquy3,Noiquy4,Noiquy5,Ngaydatphong,Ngaytraphong,Ngaydang,Ngaycapnhat")] TabDiemdenThamquan tabDiemdenThamquan)
        {
            if (ModelState.IsValid)
            {
                tabDiemdenThamquan.Hinhanh = upload(file);
                _context.Add(tabDiemdenThamquan);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Show));
            }
            ViewData["IdDiemden"] = new SelectList(_context.TabDiadiems, "IdDiadiem", "IdDiadiem", tabDiemdenThamquan.IdDiemden);
            ViewData["IdNguoidung"] = new SelectList(_context.TabNguoidungs, "IdNguoidung", "IdNguoidung", tabDiemdenThamquan.IdNguoidung);
            return View(tabDiemdenThamquan);
        }
        public IActionResult Show()
        {
            return View();
        }

        // GET: User_TabDiemdenThamquans/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tabDiemdenThamquan = await _context.TabDiemdenThamquans.FindAsync(id);
            if (tabDiemdenThamquan == null)
            {
                return NotFound();
            }
            ViewData["IdDiemden"] = new SelectList(_context.TabDiadiems, "IdDiadiem", "IdDiadiem", tabDiemdenThamquan.IdDiemden);
            ViewData["IdNguoidung"] = new SelectList(_context.TabNguoidungs, "IdNguoidung", "IdNguoidung", tabDiemdenThamquan.IdNguoidung);
            return View(tabDiemdenThamquan);
        }

        // POST: User_TabDiemdenThamquans/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdDiemdenThamquan,IdNguoidung,IdDiemden,Diachicuthe,Slngayo,Tendiadiemthamquan,Tienich,Tienich1,Tienich2,Tienich3,Tienich4,Giatien,Hinhanh,Hinhphu1,Hinhphu2,Hinhphu3,Hinhphu4,Noiquy1,Noiquy2,Noiquy3,Noiquy4,Noiquy5,Ngaydatphong,Ngaytraphong,Ngaydang,Ngaycapnhat")] TabDiemdenThamquan tabDiemdenThamquan)
        {
            if (id != tabDiemdenThamquan.IdDiemdenThamquan)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tabDiemdenThamquan);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TabDiemdenThamquanExists(tabDiemdenThamquan.IdDiemdenThamquan))
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
            ViewData["IdDiemden"] = new SelectList(_context.TabDiadiems, "IdDiadiem", "IdDiadiem", tabDiemdenThamquan.IdDiemden);
            ViewData["IdNguoidung"] = new SelectList(_context.TabNguoidungs, "IdNguoidung", "IdNguoidung", tabDiemdenThamquan.IdNguoidung);
            return View(tabDiemdenThamquan);
        }

        // GET: User_TabDiemdenThamquans/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tabDiemdenThamquan = await _context.TabDiemdenThamquans
                .Include(t => t.IdDiemdenNavigation)
                .Include(t => t.IdNguoidungNavigation)
                .FirstOrDefaultAsync(m => m.IdDiemdenThamquan == id);
            if (tabDiemdenThamquan == null)
            {
                return NotFound();
            }

            return View(tabDiemdenThamquan);
        }

        // POST: User_TabDiemdenThamquans/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tabDiemdenThamquan = await _context.TabDiemdenThamquans.FindAsync(id);
            _context.TabDiemdenThamquans.Remove(tabDiemdenThamquan);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TabDiemdenThamquanExists(int id)
        {
            return _context.TabDiemdenThamquans.Any(e => e.IdDiemdenThamquan == id);
        }
        public string upload(IFormFile formFile)
        {
            string fn = null;
            if (formFile != null)
            {
                fn = Guid.NewGuid().ToString() + "_" + formFile.FileName;
                var path = $"wwwroot\\Image2\\{fn}";
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    formFile.CopyTo(stream);
                }
            }
            return fn;

        }
    }
}
