using System;
using System.Collections.Generic;

#nullable disable

namespace Website_DatPhong_TrucTuyen.Models
{
    public partial class TabHomestay
    {
        public TabHomestay()
        {
            TabDanhgia = new HashSet<TabDanhgium>();
        }

        public int IdHomstay { get; set; }
        public int? IdNguoidung { get; set; }
        public int? IdDiadiem { get; set; }
        public string Tenhomestay { get; set; }
        public int? Slngayo { get; set; }
        public DateTime? Ngayden { get; set; }
        public DateTime? Ngaydi { get; set; }
        public string Diachicuthe { get; set; }
        public string Tieude { get; set; }
        public string Noidung { get; set; }
        public string Noiquy { get; set; }
        public double? Giatien { get; set; }
        public string Hinhanh { get; set; }
        public string Tienich1 { get; set; }
        public string Tienich2 { get; set; }
        public string Tienich3 { get; set; }
        public string Tienich4 { get; set; }
        public string Tienich5 { get; set; }
        public string Hinh1 { get; set; }
        public string Hinh2 { get; set; }
        public string Hinh3 { get; set; }
        public string Hinh4 { get; set; }
        public string Noiquy1 { get; set; }
        public string Noiquy2 { get; set; }
        public string Noiquy3 { get; set; }
        public string Noiquy4 { get; set; }
        public string Noiquy5 { get; set; }
        public DateTime? Ngaydang { get; set; }

        public virtual TabDiadiem IdDiadiemNavigation { get; set; }
        public virtual TabNguoidung IdNguoidungNavigation { get; set; }
        public virtual CartItem CartItem { get; set; }
        public virtual ICollection<TabDanhgium> TabDanhgia { get; set; }
    }
}
