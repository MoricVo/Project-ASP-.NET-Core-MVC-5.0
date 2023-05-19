using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Website_DatPhong_TrucTuyen.Models;

namespace Website_DatPhong_TrucTuyen.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class Admin_TabKhachhangsController : Controller
    {
        private readonly csdl_doan_congnghewebContext _context;
        public INotyfService  _notyfService { get; }

        public Admin_TabKhachhangsController(csdl_doan_congnghewebContext context, INotyfService notyfService)
        {
            _context = context;
            _notyfService = notyfService;
        }

        // GET: Admin/Admin_TabKhachhangs
        public async Task<IActionResult> Index()
        {
            return View(await _context.TabKhachhangs.ToListAsync());
        }

        // GET: Admin/Admin_TabKhachhangs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tabKhachhang = await _context.TabKhachhangs
                .FirstOrDefaultAsync(m => m.IdKhachhang == id);
            if (tabKhachhang == null)
            {
                return NotFound();
            }

            return View(tabKhachhang);
        }

        // GET: Admin/Admin_TabKhachhangs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/Admin_TabKhachhangs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdKhachhang,Tenkhachhang,Sdt,Diachi,Email,Slnguoio,Ghichu")] TabKhachhang tabKhachhang)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tabKhachhang);
                await _context.SaveChangesAsync();
                _notyfService.Success("Thêm dữ liệu thành công!");
              
                return RedirectToAction(nameof(Index));
            }
            return View(tabKhachhang);
        }

        // GET: Admin/Admin_TabKhachhangs/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tabKhachhang = await _context.TabKhachhangs.FindAsync(id);
            if (tabKhachhang == null)
            {
                return NotFound();
            }
            return View(tabKhachhang);
        }

        // POST: Admin/Admin_TabKhachhangs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id, [Bind("IdKhachhang,Tenkhachhang,Sdt,Diachi,Email,Slnguoio,Ghichu")] TabKhachhang tabKhachhang)
        {
            if (id != tabKhachhang.IdKhachhang)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tabKhachhang);
                    await _context.SaveChangesAsync();
                    _notyfService.Success("Cập nhật thành công!");
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TabKhachhangExists(tabKhachhang.IdKhachhang))
                    {
                        _notyfService.Error("Đã có lỗi xảy ra!");
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(tabKhachhang);
        }

        // GET: Admin/Admin_TabKhachhangs/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tabKhachhang = await _context.TabKhachhangs
                .FirstOrDefaultAsync(m => m.IdKhachhang == id);
            if (tabKhachhang == null)
            {
                return NotFound();
            }

            return View(tabKhachhang);
        }

        // POST: Admin/Admin_TabKhachhangs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var tabKhachhang = await _context.TabKhachhangs.FindAsync(id);
            _context.TabKhachhangs.Remove(tabKhachhang);
            _notyfService.Success("Xóa thành công!");
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TabKhachhangExists(int id)
        {
            return _context.TabKhachhangs.Any(e => e.IdKhachhang == id);
        }
    }
}
