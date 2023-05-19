using System;
using System.Collections.Generic;

#nullable disable

namespace Website_DatPhong_TrucTuyen.Models
{
    public partial class TabDsDangky
    {
        public string IdDs { get; set; }
        public string IdKhachhang { get; set; }
        public string IdDiemdenThamquan { get; set; }
        public string IdHomestay { get; set; }
        public DateTime? NgayLap { get; set; }

        public virtual TabDiemdenThamquan IdDiemdenThamquanNavigation { get; set; }
        public virtual TabHomestay IdHomestayNavigation { get; set; }
        public virtual TabKhachhang IdKhachhangNavigation { get; set; }
    }
}
