using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvc_intermediate.Models
{
    public class UrunCategoryModel
    {
        public int UrunSayisi { get; set; }
        public List<Urun> Urunler { get; set; }

    }
}