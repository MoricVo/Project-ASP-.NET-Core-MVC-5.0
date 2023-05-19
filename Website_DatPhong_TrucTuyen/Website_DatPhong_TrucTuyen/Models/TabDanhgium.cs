using System;
using System.Collections.Generic;

#nullable disable

namespace Website_DatPhong_TrucTuyen.Models
{
    public partial class TabDanhgium
    {
        public string IdDanhgia { get; set; }
        public int? IdHomestay { get; set; }
        public int? IdNguoidung { get; set; }
        public string Noidung { get; set; }
        public int? Diem { get; set; }
        public DateTime? Ngaydang { get; set; }

        public virtual TabHomestay IdHomestayNavigation { get; set; }
        public virtual TabNguoidung IdNguoidungNavigation { get; set; }
    }
}
