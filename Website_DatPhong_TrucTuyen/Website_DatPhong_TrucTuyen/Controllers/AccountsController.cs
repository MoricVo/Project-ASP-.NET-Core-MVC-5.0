using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Website_DatPhong_TrucTuyen.Extension;
using Website_DatPhong_TrucTuyen.Helpper;
using Website_DatPhong_TrucTuyen.Models;
using Website_DatPhong_TrucTuyen.ModelViews;

namespace Website_DatPhong_TrucTuyen.Controllers
{
    [Authorize]
    public class AccountsController : Controller
    {
       

        private readonly csdl_doan_congnghewebContext _context;
        public INotyfService _notyfService { get; }
        public AccountsController(csdl_doan_congnghewebContext context, INotyfService notyfService)
        {
            _context = context;
            _notyfService = notyfService;
        }
        [HttpGet]
        [AllowAnonymous]
        public IActionResult ValidatePhone(string Phone)
        {
            try
            {
                var khachhang = _context.TabNguoidungs.AsNoTracking().SingleOrDefault(x => x.Sdt.ToLower() == Phone.ToLower());
                if (khachhang != null)
                    return Json(data: "Số điện thoại : " + Phone + "đã được sử dụng");

                return Json(data: true);

            }
            catch
            {
                return Json(data: true);
            }
        }
        [HttpGet]
        [AllowAnonymous]
        public IActionResult ValidateEmail(string Email)
        {
            try
            {
                var khachhang = _context.TabNguoidungs.AsNoTracking().SingleOrDefault(x => x.Email.ToLower() == Email.ToLower());
                if (khachhang != null)
                    return Json(data: "Email : " + Email + " đã được sử dụng");
                return Json(data: true);
            }
            catch
            {
                return Json(data: true);
            }
        }
        [Route("tai-khoan-cua-toi.html", Name = "Dashboard")]
        public IActionResult Dashboard()
        {
            var taikhoanID = HttpContext.Session.GetString("IdNguoidung");
            if (taikhoanID != null)
            {
                var khachhang = _context.TabNguoidungs.AsNoTracking().SingleOrDefault(x => x.IdNguoidung == Convert.ToInt32(taikhoanID));
                if (khachhang != null)
                {
                    var lsDonHang = _context.TabBaiviets
                        
                        .AsNoTracking()
                        .Where(x => x.IdNguoidung == khachhang.IdNguoidung)
                        .OrderByDescending(x => x.Ngaydang)
                        .ToList();
                    ViewBag.DonHang = lsDonHang;





                    var lsDonHang2 = _context.TabHomestays
                           
                       .AsNoTracking()
                       .Where(x => x.IdNguoidung == khachhang.IdNguoidung)
                       .OrderByDescending(x => x.Ngaydang)
                       .ToList();
                    ViewBag.DonHang2 = lsDonHang2;




                    var lsDonHang3 = _context.TabDiemdenThamquans

                      .AsNoTracking()
                      .Where(x => x.IdNguoidung == khachhang.IdNguoidung)
                      .OrderByDescending(x => x.Ngaydang)
                      .ToList();
                    ViewBag.DonHang3 = lsDonHang3;
                    return View(khachhang);
                    
                }
            
            }
            return RedirectToAction("Login");
        }
        public async Task<IActionResult> Create(IFormFile file, [Bind("IdHomstay,IdNguoidung,IdDiadiem,Tenhomestay,Slngayo,Ngayden,Ngaydi,Diachicuthe,Tieude,Noidung,Noiquy,Giatien,Hinhanh,Tienich1,Tienich2,Tienich3,Tienich4,Tienich5,Hinh1,Hinh2,Hinh3,Hinh4,Noiquy1,Noiquy2,Noiquy3,Noiquy4,Noiquy5,Ngaydang")] TabHomestay tabHomestay)
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
        [HttpGet]
        [AllowAnonymous]
        [Route("dang-ky.html", Name = "DangKy")]
        public IActionResult DangkyTaiKhoan()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [Route("dang-ky.html", Name = "DangKy")]
        public async Task<IActionResult> DangkyTaiKhoan(RegisterViewModel taikhoan)
        {

            try
            {
                if (ModelState.IsValid)
                {
                    string salt = Utilities.GetRandomKey();
                    TabNguoidung khachhang = new TabNguoidung
                    {
                        Tennguoidung = taikhoan.FullName,
                        Diachi=taikhoan.Diachi,
                        Ngaysinh=taikhoan.NgaySinh,
                        Cmnd=taikhoan.Cmnd,
                      
                        
                        Loainguoidung=taikhoan.Loainguoidung,
                        Sdt = taikhoan.Phone.Trim().ToLower(),
                        Email = taikhoan.Email.Trim().ToLower(),

                        Matkhau = (taikhoan.Password + salt.Trim()).ToMD5(),
                        Kichhoat = true,
                        Salt = salt,
                        Ngaylap = DateTime.Now
                    };
                    try
                    {
                        _context.Add(khachhang);
                        await _context.SaveChangesAsync();
                        //Lưu Session MaKh
                        HttpContext.Session.SetString("IdNguoidung", khachhang.IdNguoidung.ToString());
                        var taikhoanID = HttpContext.Session.GetString("IdNguoidung");

                        //Identity
                        var claims = new List<Claim>
                        {
                            new Claim(ClaimTypes.Name,khachhang.Tennguoidung),
                            new Claim("IdNguoidung", khachhang.IdNguoidung.ToString())
                        };
                        ClaimsIdentity claimsIdentity = new ClaimsIdentity(claims, "login");
                        ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
                        await HttpContext.SignInAsync(claimsPrincipal);
                        _notyfService.Success("Đăng ký thành công");
                        return RedirectToAction("Dashboard", "Accounts");
                    }
                    catch
                    {
                        return RedirectToAction("DangkyTaiKhoan", "Accounts");
                    }
                }
                else
                {
                    return View(taikhoan);
                }
            }
            catch
            {
                return View(taikhoan);
            }
        }
        [AllowAnonymous]
        [Route("dang-nhap.html", Name = "DangNhap")]
        public IActionResult Login(string returnUrl = null)
        {
            var taikhoanID = HttpContext.Session.GetString("IdNguoidung");
            if (taikhoanID != null)
            {
                return RedirectToAction("Dashboard", "Accounts");
            }
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        [Route("dang-nhap.html", Name = "DangNhap")]
        public async Task<IActionResult> Login(LoginViewModel customer, string returnUrl)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    bool isEmail = Utilities.IsValidEmail(customer.UserName);
                    if (!isEmail) return View(customer);

                    var khachhang = _context.TabNguoidungs.AsNoTracking().SingleOrDefault(x => x.Email.Trim() == customer.UserName);

                    if (khachhang == null) return RedirectToAction("DangkyTaiKhoan");
                    string pass = (customer.Password + khachhang.Salt.Trim()).ToMD5();
                    if (khachhang.Matkhau != pass)
                    {
                        _notyfService.Success("Thông tin đăng nhập chưa chính xác");
                        return View(customer);
                    }
                    //kiem tra xem account co bi disable hay khong

                    if (khachhang.Kichhoat == false)
                    {
                        return RedirectToAction("ThongBao", "Accounts");
                    }

                    //Luu Session MaKh
                    HttpContext.Session.SetString("IdNguoidung", khachhang.IdNguoidung.ToString());
                    var taikhoanID = HttpContext.Session.GetString("IdNguoidung");

                    //Identity
                    var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name, khachhang.Tennguoidung),
                        new Claim("IdNguoidung", khachhang.IdNguoidung.ToString())
                    };
                    ClaimsIdentity claimsIdentity = new ClaimsIdentity(claims, "login");
                    ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
                    await HttpContext.SignInAsync(claimsPrincipal);
                    _notyfService.Success("Đăng nhập thành công");
                    if (string.IsNullOrEmpty(returnUrl))
                    {
                        return RedirectToAction("Dashboard", "Accounts");
                    }
                    else
                    {
                        return Redirect(returnUrl);
                    }
                }
            }
            catch
            {
                return RedirectToAction("DangkyTaiKhoan", "Accounts");
            }
            return View(customer);
        }
        [HttpGet]
        [Route("dang-xuat.html", Name = "DangXuat")]
        public IActionResult Logout()
        {
            HttpContext.SignOutAsync();
            HttpContext.Session.Remove("IdNguoidung");
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public async Task<IActionResult> ChangePassword(ChangePasswordViewModel model)
        {
            try
            {
                var taikhoanID = HttpContext.Session.GetString("IdNguoidung");
                if (taikhoanID == null)
                {
                    return RedirectToAction("Login", "Accounts");
                }
                if (ModelState.IsValid)
                {
                    var taikhoan = _context.TabNguoidungs.Find(Convert.ToInt32(taikhoanID));
                    if (taikhoan == null) return RedirectToAction("Login", "Accounts");
                    var pass = (model.PasswordNow.Trim() + taikhoan.Salt.Trim()).ToMD5();
                    {
                        string passnew = (model.Password.Trim() + taikhoan.Salt.Trim()).ToMD5();
                        taikhoan.Matkhau = passnew;
                         _context.Update(taikhoan);
                         _context.SaveChanges();
                        _notyfService.Success("Đổi mật khẩu thành công");
                        return RedirectToAction("Dashboard", "Accounts");
                    }
                }
            }
            catch
            {
                _notyfService.Success("Thay đổi mật khẩu không thành công");
                return RedirectToAction("Dashboard", "Accounts");
            }
            _notyfService.Success("Thay đổi mật khẩu không thành công");
            return RedirectToAction("Dashboard", "Accounts");
        }
        public async Task<IActionResult> MyProfile(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var account = await _context.TabNguoidungs.FindAsync(id);
            if (account == null)
            {
                return NotFound();
            }
            return View(account);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> MyProfile(IFormFile file,int id, [Bind("IdNguoidung,Tennguoidung,Diachi,Ngaysinh,Sdt,Email,Cmnd,Anhdaidien,Taikhoan,Matkhau,Loainguoidung,Kichhoat,Ngaylap,Salt")] TabNguoidung account)
        {
            if (id != account.IdNguoidung)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    account.Anhdaidien = upload(file);
                    _context.Update(account);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {

                }
                return RedirectToAction(nameof(CC));
            }
            return View(account);
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
        public IActionResult CC()
        {
            return View();
        }
  


    }
}
