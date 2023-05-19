using System;
using System.Collections.Generic;

#nullable disable

namespace Website_DatPhong_TrucTuyen.Models
{
    public partial class TabDiemdenThamquan
    {
        public int IdDiemdenThamquan { get; set; }
        public int? IdNguoidung { get; set; }
        public int? IdDiemden { get; set; }
        public string Diachicuthe { get; set; }
        public int? Slngayo { get; set; }
        public string Tendiadiemthamquan { get; set; }
        public string Tienich { get; set; }
        public string Tienich1 { get; set; }
        public string Tienich2 { get; set; }
        public string Tienich3 { get; set; }
        public string Tienich4 { get; set; }
        public double? Giatien { get; set; }
        public string Hinhanh { get; set; }
        public string Hinhphu1 { get; set; }
        public string Hinhphu2 { get; set; }
        public string Hinhphu3 { get; set; }
        public string Hinhphu4 { get; set; }
        public string Noiquy1 { get; set; }
        public string Noiquy2 { get; set; }
        public string Noiquy3 { get; set; }
        public string Noiquy4 { get; set; }
        public string Noiquy5 { get; set; }
        public DateTime? Ngaydatphong { get; set; }
        public DateTime? Ngaytraphong { get; set; }
        public DateTime? Ngaydang { get; set; }
        public DateTime? Ngaycapnhat { get; set; }

        public virtual TabDiadiem IdDiemdenNavigation { get; set; }
        public virtual TabNguoidung IdNguoidungNavigation { get; set; }
    }
}
