using System;
using System.Collections.Generic;

#nullable disable

namespace Website_DatPhong_TrucTuyen.Models
{
    public partial class CartItem
    {
        public int IdHomestays { get; set; }
        public int? Slphong { get; set; }

        public virtual TabHomestay IdHomestaysNavigation { get; set; }
    }
}
