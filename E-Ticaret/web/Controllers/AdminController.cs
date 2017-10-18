using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web.Service.Services;
using Web.DTO.Product;
using Web.DTO.Category;

namespace web.Controllers
{
    public class AdminController : Controller
    {
        ProductService Urunservis = new ProductService();
        CategoryService Categoryservis = new CategoryService();
        public ActionResult Urunler()
        {
            return View(Urunservis.GetAll());
        }
        public ActionResult Urunekle()
        {
            return View();

        }
        [HttpPost]
        public ActionResult Urunekle(ProductAddDTO product)
        {
            Urunservis.Add(product);
            return View();

        }
        public ActionResult UrunSil(int? id)
        {
            if (id != null)
            {
                Urunservis.Delete((int)id);
            }
            return RedirectToAction("Urunler");
        }

        public ActionResult Urundetail(int?id)
        {

            return View(Urunservis.Find((int)id));
        }
        [HttpPost]
        public ActionResult Urundetail(ProductlistDTO urun)
        {

            Urunservis.update(urun);
            return View();
        }

        public ActionResult Category()
        {
            return View(Categoryservis.GetAll());
        }


    }
}