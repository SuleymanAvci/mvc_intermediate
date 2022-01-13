using mvc_intermediate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc_intermediate.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        public ActionResult Index()
        {
            return View();
        }
        [ChildActionOnly]
        public PartialViewResult CategoryMenu()
        {
            List<Category> kategoriler = new List<Category>()
            {
                new Category{Id=1, CategoryAdi="Telefon" },
                new Category{Id=2, CategoryAdi="Bilgisayar" },
                new Category{Id=3, CategoryAdi="Tablet" }
            };

            return PartialView("CategoryMenu",kategoriler);
        }
    }
}