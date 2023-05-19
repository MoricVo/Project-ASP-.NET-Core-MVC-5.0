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

namespace Website_DatPhong_TrucTuyen.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class Admin_TabHomestaysController : Controller
    {
        private readonly csdl_doan_congnghewebContext _context;

        public Admin_TabHomestaysController(csdl_doan_congnghewebContext context)
        {
            this._context = context;
        }
        // GET: Admin/Admin_TabHomestays
        public async Task<IActionResult> Index()
        {
          
            var csdl_doan_congnghewebContext = _context.TabHomestays.Include(t => t.IdDiadiemNavigation).Include(t => t.IdNguoidungNavigation);
            return View(await csdl_doan_congnghewebContext.ToListAsync());
        }
        [HttpGet]
        public IActionResult PhanLoai(int? IdNguoidung)
        {
            IdNguoidung = IdNguoidung ?? 0;
            var Categories = _context.TabNguoidungs.ToList();
            Categories.Insert(0, new TabNguoidung { IdNguoidung = 0, Tennguoidung = "----Chọn người dùng----" });
            ViewBag.IdNguoidung = new SelectList(Categories, "IdNguoidung", "Tennguoidung", IdNguoidung);
            var cm = _context.TabHomestays.Where(x => x.IdNguoidung == IdNguoidung);
            return View(cm);

        }
        public async Task<IActionResult> TimKiem(string Name)
        {
            var Home = from b in _context.TabHomestays select b;
            if (!string.IsNullOrEmpty(Name))
            {
                Home = Home.Where(x => x.Tenhomestay.Contains(Name)||x.Diachicuthe.Contains(Name)||x.IdNguoidungNavigation.Tennguoidung.Contains(Name));
            }
            return View(Home);
        }
        // GET: Admin/Admin_TabHomestays/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tabHomestay = await _context.TabHomestays
                .Include(t => t.IdDiadiemNavigation)
                .Include(t => t.IdNguoidungNavigation)
                .FirstOrDefaultAsync(m => m.IdHomstay == id);
            if (tabHomestay == null)
            {
                return NotFound();
            }

            return View(tabHomestay);
        }

        // GET: Admin/Admin_TabHomestays/Create
        public IActionResult Create()
        {
            ViewData["IdDiadiem"] = new SelectList(_context.TabDiadiems, "IdDiadiem", "Tendiadiem");
            ViewData["IdNguoidung"] = new SelectList(_context.TabNguoidungs, "IdNguoidung", "Tennguoidung");
            return View();
        }

        // POST: Admin/Admin_TabHomestays/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(IFormFile file,[Bind("IdHomstay,IdNguoidung,IdDiadiem,Tenhomestay,Slngayo,Ngayden,Ngaydi,Diachicuthe,Tieude,Noidung,Noiquy,Giatien,Hinhanh,Tienich1,Tienich2,Tienich3,Tienich4,Tienich5,Hinh1,Hinh2,Hinh3,Hinh4,Noiquy1,Noiquy2,Noiquy3,Noiquy4,Noiquy5,Ngaydang")] TabHomestay tabHomestay)
        {
            if (ModelState.IsValid)
            {
                tabHomestay.Hinhanh = upload(file);
                _context.Add(tabHomestay);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdDiadiem"] = new SelectList(_context.TabDiadiems, "IdDiadiem", "IdDiadiem", tabHomestay.IdDiadiem);
            ViewData["IdNguoidung"] = new SelectList(_context.TabNguoidungs, "IdNguoidung", "IdNguoidung", tabHomestay.IdNguoidung);
            return View(tabHomestay);
        }

        // GET: Admin/Admin_TabHomestays/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tabHomestay = await _context.TabHomestays.FindAsync(id);
            if (tabHomestay == null)
            {
                return NotFound();
            }
            ViewData["IdDiadiem"] = new SelectList(_context.TabDiadiems, "IdDiadiem", "Tendiadiem", tabHomestay.IdDiadiem);
            ViewData["IdNguoidung"] = new SelectList(_context.TabNguoidungs, "IdNguoidung", "Tennguoidung", tabHomestay.IdNguoidung);
            return View(tabHomestay);
        }

        // POST: Admin/Admin_TabHomestays/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(IFormFile file,int id, [Bind("IdHomstay,IdNguoidung,IdDiadiem,Tenhomestay,Slngayo,Ngayden,Ngaydi,Diachicuthe,Tieude,Noidung,Noiquy,Giatien,Hinhanh,Tienich1,Tienich2,Tienich3,Tienich4,Tienich5,Hinh1,Hinh2,Hinh3,Hinh4,Noiquy1,Noiquy2,Noiquy3,Noiquy4,Noiquy5,Ngaydang")] TabHomestay tabHomestay)
        {
            if (id != tabHomestay.IdHomstay)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    tabHomestay.Hinhanh = upload(file);
                    _context.Update(tabHomestay);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TabHomestayExists(tabHomestay.IdHomstay))
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
            ViewData["IdDiadiem"] = new SelectList(_context.TabDiadiems, "IdDiadiem", "IdDiadiem", tabHomestay.IdDiadiem);
            ViewData["IdNguoidung"] = new SelectList(_context.TabNguoidungs, "IdNguoidung", "IdNguoidung", tabHomestay.IdNguoidung);
            return View(tabHomestay);
        }

        // GET: Admin/Admin_TabHomestays/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tabHomestay = await _context.TabHomestays
                .Include(t => t.IdDiadiemNavigation)
                .Include(t => t.IdNguoidungNavigation)
                .FirstOrDefaultAsync(m => m.IdHomstay == id);
            if (tabHomestay == null)
            {
                return NotFound();
            }

            return View(tabHomestay);
        }

        // POST: Admin/Admin_TabHomestays/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tabHomestay = await _context.TabHomestays.FindAsync(id);
            _context.TabHomestays.Remove(tabHomestay);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TabHomestayExists(int id)
        {
            return _context.TabHomestays.Any(e => e.IdHomstay == id);
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
