using System;
using System.Collections.Generic;

#nullable disable

namespace Website_DatPhong_TrucTuyen.Models
{
    public partial class TabDiadiem
    {
        public TabDiadiem()
        {
            TabDiemdenThamquans = new HashSet<TabDiemdenThamquan>();
            TabHomestays = new HashSet<TabHomestay>();
        }

        public int IdDiadiem { get; set; }
        public int? IdNguoidung { get; set; }
        public string Tendiadiem { get; set; }
        public string Hinhanh { get; set; }
        public int? SlTours { get; set; }
        public DateTime? Ngaydang { get; set; }

        public virtual TabNguoidung IdNguoidungNavigation { get; set; }
        public virtual ICollection<TabDiemdenThamquan> TabDiemdenThamquans { get; set; }
        public virtual ICollection<TabHomestay> TabHomestays { get; set; }
    }
}
