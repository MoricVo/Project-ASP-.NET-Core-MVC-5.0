using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Website_DatPhong_TrucTuyen.Models;

namespace Website_DatPhong_TrucTuyen.ModelViews
{
    public class CartItem
    {
        public TabHomestay homestay { get; set; }
        public int amount { get; set; }
        //public double TotalMoney => amount *homestay.Giatien.Value;
    }
}
