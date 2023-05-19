using System;
using System.Collections.Generic;

#nullable disable

namespace Website_DatPhong_TrucTuyen.Models
{
    public partial class TabGioithieu
    {
        public string IdGioithieu { get; set; }
        public int? IdNguoidung { get; set; }
        public string Tieude { get; set; }
        public string Noidung { get; set; }
        public string Icon { get; set; }
        public string Hinhanh { get; set; }

        public virtual TabNguoidung IdNguoidungNavigation { get; set; }
    }
}
