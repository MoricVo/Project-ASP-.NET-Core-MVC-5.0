using System;
using System.Collections.Generic;

#nullable disable

namespace Website_DatPhong_TrucTuyen.Models
{
    public partial class TabChude
    {
        public TabChude()
        {
            TabBaiviets = new HashSet<TabBaiviet>();
        }

        public string IdChude { get; set; }
        public string Tenchude { get; set; }
        public string Ghichu { get; set; }
        public DateTime? Ngaydang { get; set; }

        public virtual ICollection<TabBaiviet> TabBaiviets { get; set; }
    }
}
