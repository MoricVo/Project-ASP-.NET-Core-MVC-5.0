using System;
using System.Collections.Generic;

#nullable disable

namespace Website_DatPhong_TrucTuyen.Models
{
    public partial class TabYeuthich
    {
        public string IdYeuthich { get; set; }
        public int? IdNguoidung { get; set; }
        public string IdHomestay { get; set; }
        public string Ghichu { get; set; }

        public virtual TabNguoidung IdNguoidungNavigation { get; set; }
    }
}
