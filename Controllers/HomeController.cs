using mvc_intermediate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc_intermediate.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {

            List<Urun> urunler = new List<Urun>()
            {
                new Urun(){UrunId=1, UrunAdi="Samsung S6", Aciklama="idare eder", Fiyat=1000, Satistami=true},
                new Urun(){UrunId=2, UrunAdi="Samsung S7", Aciklama="idare eder", Fiyat=2000, Satistami=true},
                new Urun(){UrunId=3, UrunAdi="Samsung S8", Aciklama="idare eder", Fiyat=3000, Satistami=false},
                new Urun(){UrunId=4, UrunAdi="Samsung S10", Aciklama="idare eder", Fiyat=3500, Satistami=true},
                new Urun(){UrunId=5, UrunAdi="Samsung S20", Aciklama="idare eder", Fiyat=5000, Satistami=false},
                new Urun(){UrunId=6, UrunAdi="Samsung S22", Aciklama="idare eder", Fiyat=6000, Satistami=true},
                new Urun(){UrunId=7, UrunAdi="Samsung SYX", Aciklama="idare eder", Fiyat=4400, Satistami=false},
                new Urun(){UrunId=8, UrunAdi="Samsung SKK", Aciklama="idare eder", Fiyat=6500, Satistami=true},
                new Urun(){UrunId=9, UrunAdi="Samsung SX1", Aciklama="idare eder", Fiyat=10000, Satistami=true}
            };

          

            UrunCategoryModel model = new UrunCategoryModel();
            
            model.Urunler = urunler;
            model.UrunSayisi = urunler.Count();

            //ViewBag.Kategoriler = Kategoriler;
            //ViewBag.Urunsayisi = urunler.Count();
            return View(model);
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }


}