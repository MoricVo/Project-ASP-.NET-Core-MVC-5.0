using System;
using System.Collections.Generic;

#nullable disable

namespace Website_DatPhong_TrucTuyen.Models
{
    public partial class TabKhachhang
    {
        public int IdKhachhang { get; set; }
        public string Tenkhachhang { get; set; }
        public int? Sdt { get; set; }
        public string Diachi { get; set; }
        public string Email { get; set; }
        public int? Slnguoio { get; set; }
        public string Ghichu { get; set; }
    }
}
