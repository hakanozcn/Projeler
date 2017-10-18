using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using websitedb.data.dataclass;
using websit.Models;


namespace websit.Controllers
{

    public class HomeController : BaseController
    {
        private wcontext db = new wcontext();

        public ActionResult Makaledetail(int? id)
        {
            Makaledetailview Makale = new Makaledetailview();
            Makale.Makale = db.Yazilar.Find(id);
            Makale.Category = db.Category.ToList();
            Makale.Blogers = db.Blogger.Find(Makale.Makale.BlogerID);
            return View(Makale);
        }


        public ActionResult makale(int? id)
        {
            Makaleview makaleler = new Makaleview();

            makaleler.Makaleler = db.Yazilar.Where(x => (x.CategoryiD == id)).ToList();
            makaleler.Category = db.Category.ToList();
            return View(makaleler);




        }

        public ActionResult Index()
        {


           

            İndexview index = new İndexview();
            index.Duyulular = db.Duyulular.ToList();
            index.Etkinlik = db.Etkinlik.ToList();
            index.Yazilar = db.Yazilar.ToList();
            index.Slider = db.Slider.ToList();
            index.Category = db.Category.ToList();

            return View(index);
        }
    
  
        public ActionResult About()
        {
            

            return View();
        }

        public ActionResult Contact()
        {
            

            return View();
        }
        public ActionResult threads()
        {
            
            return View();

        }

        public ActionResult MakaleADD(int?id)
        {
            
            List<SelectListItem> Categrydroplist = (from k in db.Category
                                                    select new SelectListItem
                                                    {
                                                        Text = k.Categoryname,
                                                        Value = k.ID.ToString()

                                                    }).ToList();


            ViewBag.Droplist = Categrydroplist;
            MakaleADDview makale = new MakaleADDview();
            makale.Category = db.Category.ToList();
            
            return View(makale);
        }
    [HttpPost]
    public ActionResult MakaleADD(MakaleADDview model)
        {
            
            yazi makale = new yazi();
            
            if (model==null||model.file != null)
            {
                model.file.SaveAs(Server.MapPath("~/Imj/Makale/") + model.file.FileName);

            }

            if (ModelState.IsValid)
            {
                makale.img = "/Imj/Makale/" + model.file.FileName;
                makale.Baslik = model.Baslik;
                makale.İcerik = model.İcerik;
                makale.Updatetime = DateTime.Now;
                makale.CategoryiD =Convert.ToInt32( model.CategoryiD);
                
                model.blogerID = Convert.ToInt32(Session["ID"]);
                makale.bloggerID =db.Blogger.Find(model.blogerID);
            }
            db.Yazilar.Add(makale);
            db.SaveChanges();

            return RedirectToAction("makale") ;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
   

}







