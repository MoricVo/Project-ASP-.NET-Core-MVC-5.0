using System;
using System.Collections.Generic;

#nullable disable

namespace Website_DatPhong_TrucTuyen.Models
{
    public partial class TabNguoidung
    {
        public TabNguoidung()
        {
            TabBaiviets = new HashSet<TabBaiviet>();
            TabDanhgia = new HashSet<TabDanhgium>();
            TabDiadiems = new HashSet<TabDiadiem>();
            TabDiemdenThamquans = new HashSet<TabDiemdenThamquan>();
            TabGioithieus = new HashSet<TabGioithieu>();
            TabHomestays = new HashSet<TabHomestay>();
            TabYeuthiches = new HashSet<TabYeuthich>();
        }

        public int IdNguoidung { get; set; }
        public string Tennguoidung { get; set; }
        public string Diachi { get; set; }
        public DateTime? Ngaysinh { get; set; }
        public string Sdt { get; set; }
        public string Email { get; set; }
        public int? Cmnd { get; set; }
        public string Anhdaidien { get; set; }
        public string Taikhoan { get; set; }
        public string Matkhau { get; set; }
        public string Loainguoidung { get; set; }
        public bool? Kichhoat { get; set; }
        public DateTime? Ngaylap { get; set; }
        public string Salt { get; set; }

        public virtual ICollection<TabBaiviet> TabBaiviets { get; set; }
        public virtual ICollection<TabDanhgium> TabDanhgia { get; set; }
        public virtual ICollection<TabDiadiem> TabDiadiems { get; set; }
        public virtual ICollection<TabDiemdenThamquan> TabDiemdenThamquans { get; set; }
        public virtual ICollection<TabGioithieu> TabGioithieus { get; set; }
        public virtual ICollection<TabHomestay> TabHomestays { get; set; }
        public virtual ICollection<TabYeuthich> TabYeuthiches { get; set; }
    }
}
