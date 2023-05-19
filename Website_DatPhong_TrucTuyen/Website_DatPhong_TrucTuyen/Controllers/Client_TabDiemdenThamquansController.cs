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
    public class Client_TabDiemdenThamquansController : Controller
    {
        private readonly csdl_doan_congnghewebContext _context;

        public Client_TabDiemdenThamquansController(csdl_doan_congnghewebContext context)
        {
            _context = context;
        }

        // GET: Client_TabDiemdenThamquans
        public async Task<IActionResult> Index()
        {
            var csdl_doan_congnghewebContext = _context.TabDiemdenThamquans.Include(t => t.IdDiemdenNavigation).Include(t => t.IdNguoidungNavigation);
            return View(await csdl_doan_congnghewebContext.ToListAsync());
        }
        public async Task<IActionResult> TimKiem(string Name)
        {
            var Home = from b in _context.TabDiemdenThamquans select b;
            if (!string.IsNullOrEmpty(Name))
            {
                Home = Home.Where(x => x.Tendiadiemthamquan.Contains(Name) || x.Diachicuthe.Contains(Name));
            }
            return View(Home);
        }
        public IActionResult PhanLoai(int? IdNguoidung)
        {
            IdNguoidung = IdNguoidung ?? 0;
            var Categories = _context.TabNguoidungs.ToList();
            Categories.Insert(0, new TabNguoidung { IdNguoidung = 0, Tennguoidung = "----Chọn người dùng----" });
            ViewBag.IdNguoidung = new SelectList(Categories, "IdNguoidung", "Tennguoidung", IdNguoidung);
            var cm = _context.TabDiemdenThamquans.Where(x => x.IdNguoidung == IdNguoidung);
            return View(cm);

        }
        public IActionResult PhanLoai2(int? IdDiadiem)
        {

            IdDiadiem = IdDiadiem ?? 0;
            var Categories = _context.TabDiadiems.ToList();
            Categories.Insert(0, new TabDiadiem { IdDiadiem = 0, Tendiadiem = "----Chọn địa điểm----" });
            ViewBag.IdDiadiem = new SelectList(Categories, "IdDiadiem", "Tendiadiem", IdDiadiem);
            var cm = _context.TabDiemdenThamquans.Where(x => x.IdDiemden == IdDiadiem);
            return View(cm);

        }
        // GET: Client_TabDiemdenThamquans/Details/5
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

        // GET: Client_TabDiemdenThamquans/Create
        public IActionResult Create()
        {
            ViewData["IdDiemden"] = new SelectList(_context.TabDiadiems, "IdDiadiem", "IdDiadiem");
            ViewData["IdNguoidung"] = new SelectList(_context.TabNguoidungs, "IdNguoidung", "IdNguoidung");
            return View();
        }

        // POST: Client_TabDiemdenThamquans/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdDiemdenThamquan,IdNguoidung,IdDiemden,Diachicuthe,Slngayo,Tendiadiemthamquan,Tienich,Tienich1,Tienich2,Tienich3,Tienich4,Giatien,Hinhanh,Hinhphu1,Hinhphu2,Hinhphu3,Hinhphu4,Noiquy1,Noiquy2,Noiquy3,Noiquy4,Noiquy5,Ngaydatphong,Ngaytraphong,Ngaydang,Ngaycapnhat")] TabDiemdenThamquan tabDiemdenThamquan)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tabDiemdenThamquan);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdDiemden"] = new SelectList(_context.TabDiadiems, "IdDiadiem", "IdDiadiem", tabDiemdenThamquan.IdDiemden);
            ViewData["IdNguoidung"] = new SelectList(_context.TabNguoidungs, "IdNguoidung", "IdNguoidung", tabDiemdenThamquan.IdNguoidung);
            return View(tabDiemdenThamquan);
        }

        // GET: Client_TabDiemdenThamquans/Edit/5
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

        // POST: Client_TabDiemdenThamquans/Edit/5
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

        // GET: Client_TabDiemdenThamquans/Delete/5
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

        // POST: Client_TabDiemdenThamquans/Delete/5
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
    }
}
