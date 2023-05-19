using System;
using System.Collections.Generic;

#nullable disable

namespace Website_DatPhong_TrucTuyen.Models
{
    public partial class TabBaiviet
    {
        public string IdBaiviet { get; set; }
        public int? IdNguoidung { get; set; }
        public string IdChude { get; set; }
        public string Tieude { get; set; }
        public string Noidung { get; set; }
        public string Ghichu { get; set; }
        public string Hinhanh { get; set; }
        public DateTime? Ngaydang { get; set; }
        public int? Luotxem { get; set; }
        public int? Kiemduyet { get; set; }

        public virtual TabChude IdChudeNavigation { get; set; }
        public virtual TabNguoidung IdNguoidungNavigation { get; set; }
    }
}
