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
    public class Admin_TabNguoidungsController : Controller
    {
        private readonly csdl_doan_congnghewebContext _context;

        public Admin_TabNguoidungsController(csdl_doan_congnghewebContext context)
        {
            _context = context;
        }

        // GET: Admin/Admin_TabNguoidungs
        public async Task<IActionResult> Index()
        {
            return View(await _context.TabNguoidungs.ToListAsync());
        }
        public async Task<IActionResult> TimKiem(string Name)
        {
            var Home = from b in _context.TabNguoidungs select b;
            if (!string.IsNullOrEmpty(Name))
            {
                Home = Home.Where(x => x.Tennguoidung.Contains(Name)||x.Email.Contains(Name)||x.Diachi.Contains(Name));
            }
            return View(Home);
        }
        // GET: Admin/Admin_TabNguoidungs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tabNguoidung = await _context.TabNguoidungs
                .FirstOrDefaultAsync(m => m.IdNguoidung == id);
            if (tabNguoidung == null)
            {
                return NotFound();
            }

            return View(tabNguoidung);
        }

        // GET: Admin/Admin_TabNguoidungs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/Admin_TabNguoidungs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(IFormFile file,[Bind("IdNguoidung,Tennguoidung,Diachi,Ngaysinh,Sdt,Email,Cmnd,Anhdaidien,Taikhoan,Matkhau,Loainguoidung,Kichhoat,Ngaylap,Salt")] TabNguoidung tabNguoidung)
        {
            if (ModelState.IsValid)
            {
                tabNguoidung.Anhdaidien = upload(file);
                _context.Add(tabNguoidung);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tabNguoidung);
        }

        // GET: Admin/Admin_TabNguoidungs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tabNguoidung = await _context.TabNguoidungs.FindAsync(id);
            if (tabNguoidung == null)
            {
                return NotFound();
            }
            return View(tabNguoidung);
        }

        // POST: Admin/Admin_TabNguoidungs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(IFormFile file,int id, [Bind("IdNguoidung,Tennguoidung,Diachi,Ngaysinh,Sdt,Email,Cmnd,Anhdaidien,Taikhoan,Matkhau,Loainguoidung,Kichhoat,Ngaylap,Salt")] TabNguoidung tabNguoidung)
        {
            if (id != tabNguoidung.IdNguoidung)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    tabNguoidung.Anhdaidien = upload(file);
                    _context.Update(tabNguoidung);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TabNguoidungExists(tabNguoidung.IdNguoidung))
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
            return View(tabNguoidung);
        }

        // GET: Admin/Admin_TabNguoidungs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tabNguoidung = await _context.TabNguoidungs
                .FirstOrDefaultAsync(m => m.IdNguoidung == id);
            if (tabNguoidung == null)
            {
                return NotFound();
            }

            return View(tabNguoidung);
        }

        // POST: Admin/Admin_TabNguoidungs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tabNguoidung = await _context.TabNguoidungs.FindAsync(id);
            _context.TabNguoidungs.Remove(tabNguoidung);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TabNguoidungExists(int id)
        {
            return _context.TabNguoidungs.Any(e => e.IdNguoidung == id);
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
