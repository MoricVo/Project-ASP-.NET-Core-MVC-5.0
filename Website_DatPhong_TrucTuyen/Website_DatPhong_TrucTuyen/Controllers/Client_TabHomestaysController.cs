using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Website_DatPhong_TrucTuyen.Models;

namespace Website_DatPhong_TrucTuyen.Controllers
{
    public class Client_TabHomestaysController : Controller
    {
        private readonly csdl_doan_congnghewebContext _context;
        public INotyfService _notyfService { get; }
        public Client_TabHomestaysController(csdl_doan_congnghewebContext context, INotyfService notyfService)
        {
            _context = context;
            _notyfService = notyfService;
        }

        // GET: Client_TabHomestays
        public async Task<IActionResult> Index()
        {
            var csdl_doan_congnghewebContext = _context.TabHomestays.Include(t => t.IdDiadiemNavigation).Include(t => t.IdNguoidungNavigation);
            return View(await csdl_doan_congnghewebContext.ToListAsync());
        }
        public async Task<IActionResult> TimKiem(string Name)
        {
            var Home = from b in _context.TabHomestays select b;
            if (!string.IsNullOrEmpty(Name))
            {
                Home = Home.Where(x => x.Tenhomestay.Contains(Name)||x.Tieude.Contains(Name));
            }
            return View(Home);
        }
        // GET: Client_TabHomestays/Details/5
        public IActionResult PhanLoai(int? IdNguoidung)
        {
            IdNguoidung = IdNguoidung ?? 0;
            var Categories = _context.TabNguoidungs.ToList();
            Categories.Insert(0, new TabNguoidung {IdNguoidung = 0, Tennguoidung = "----Chọn người dùng----" });
            ViewBag.IdNguoidung = new SelectList(Categories, "IdNguoidung", "Tennguoidung", IdNguoidung);
            var cm = _context.TabHomestays.Where(x => x.IdNguoidung == IdNguoidung);
            return View(cm);

        }
        public IActionResult PhanLoai2(int? IdDiadiem)
        {
          
            IdDiadiem = IdDiadiem ?? 0;
            var Categories = _context.TabDiadiems.ToList();
            Categories.Insert(0, new TabDiadiem {IdDiadiem = 0, Tendiadiem = "----Chọn địa điểm----" });
            ViewBag.IdDiadiem = new SelectList(Categories, "IdDiadiem", "Tendiadiem", IdDiadiem);
            var cm = _context.TabHomestays.Where(x => x.IdDiadiem == IdDiadiem);
            return View(cm);

        }
        List<CartItem> GetCartItems()
        {
            var session = HttpContext.Session;
            string jsoncart = session.GetString("shopcart");
            if (jsoncart != null)
            {
                return JsonConvert.DeserializeObject<List<CartItem>>(jsoncart);
            }
            return new List<CartItem>();
        }
        void SaveCartSession(List<CartItem> list)
        {
            var session = HttpContext.Session;
            string jsoncart = JsonConvert.SerializeObject(list);
            session.SetString("shopcart", jsoncart);
        }
        public async Task<IActionResult> AddToCart(int id)
        {
            var product = await _context.TabHomestays
                .FirstOrDefaultAsync(m => m.IdHomstay == id);
                
            if (product == null)
            {
                return NotFound("Sản phẩm không tồn tại");
            }
            var cart = GetCartItems();
            var item = cart.Find(p => p.IdHomestays == id);
            if (item != null)
            {
                item.Slphong++;
            }
            else
            {
                cart.Add(new CartItem() { IdHomestays = product.IdHomstay, Slphong = 1 });
            }
            ViewBag.Product1 = product;
            SaveCartSession(cart);
            return RedirectToAction(nameof(CheckOut));
        }
        public IActionResult CheckOut()
        {
            return View(GetCartItems());
        }
        [HttpPost, ActionName("CreateBill")]
        public async Task<IActionResult> CreateBill(int IdKhachhang,string cusName, int cusPhone, string cusAddress, string billTotal,int SL,string Email)
        {
            var bill = new TabKhachhang();
            bill.IdKhachhang = IdKhachhang;
            bill.Tenkhachhang = cusName;
            bill.Sdt = cusPhone;
            bill.Diachi = cusAddress;
            bill.Slnguoio = SL;
            bill.Ghichu = billTotal;
            bill.Email = Email;
            _context.Add(bill);
            await _context.SaveChangesAsync();
            _notyfService.Success("Đặt phòng thành công!");
            //Xoá thông tin giỏ
            ClearCart();

            return RedirectToAction(nameof(Shiba));
        }
        public IActionResult Shiba()
        {
            return View();
        }
        void ClearCart()
        {
            var session = HttpContext.Session;
            session.Remove("shopcart");
        }
       
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

        // GET: Client_TabHomestays/Create
        public IActionResult Create()
        {
            ViewData["IdDiadiem"] = new SelectList(_context.TabDiadiems, "IdDiadiem", "IdDiadiem");
            ViewData["IdNguoidung"] = new SelectList(_context.TabNguoidungs, "IdNguoidung", "IdNguoidung");
            return View();
        }

        // POST: Client_TabHomestays/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdHomstay,IdNguoidung,IdDiadiem,Tenhomestay,Slngayo,Ngayden,Ngaydi,Diachicuthe,Tieude,Noidung,Noiquy,Giatien,Hinhanh,Tienich1,Tienich2,Tienich3,Tienich4,Tienich5,Hinh1,Hinh2,Hinh3,Hinh4,Noiquy1,Noiquy2,Noiquy3,Noiquy4,Noiquy5,Ngaydang")] TabHomestay tabHomestay)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tabHomestay);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdDiadiem"] = new SelectList(_context.TabDiadiems, "IdDiadiem", "IdDiadiem", tabHomestay.IdDiadiem);
            ViewData["IdNguoidung"] = new SelectList(_context.TabNguoidungs, "IdNguoidung", "IdNguoidung", tabHomestay.IdNguoidung);
            return View(tabHomestay);
        }

        // GET: Client_TabHomestays/Edit/5
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
            ViewData["IdDiadiem"] = new SelectList(_context.TabDiadiems, "IdDiadiem", "IdDiadiem", tabHomestay.IdDiadiem);
            ViewData["IdNguoidung"] = new SelectList(_context.TabNguoidungs, "IdNguoidung", "IdNguoidung", tabHomestay.IdNguoidung);
            return View(tabHomestay);
        }

        // POST: Client_TabHomestays/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdHomstay,IdNguoidung,IdDiadiem,Tenhomestay,Slngayo,Ngayden,Ngaydi,Diachicuthe,Tieude,Noidung,Noiquy,Giatien,Hinhanh,Tienich1,Tienich2,Tienich3,Tienich4,Tienich5,Hinh1,Hinh2,Hinh3,Hinh4,Noiquy1,Noiquy2,Noiquy3,Noiquy4,Noiquy5,Ngaydang")] TabHomestay tabHomestay)
        {
            if (id != tabHomestay.IdHomstay)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
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

        // GET: Client_TabHomestays/Delete/5
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

        // POST: Client_TabHomestays/Delete/5
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
    }
}
