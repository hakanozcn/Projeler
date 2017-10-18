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
    public class bloggersController : BaseController
    {
       
        private wcontext Db = new wcontext();


        public ActionResult Duyulular()
        {


            return View(Db.Duyulular.ToList());
        }

        public ActionResult DuyuruAdd()
        {

            return View();
        }
        [HttpPost]
        public ActionResult DuyuruAdd(duyulular model)
        {if(model!=null)
            {
                
                model.Blogerid = Convert.ToInt32(Session["ID"]);
                model.BloggeID = Db.Blogger.Find(model.Blogerid);
                model.Updatetime = DateTime.Now;
                Db.Duyulular.Add(model);
                Db.SaveChanges();
            }
            
            return RedirectToAction("Duyulular");
        }
        public ActionResult DuyuruDelete(int? id)
        {

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            duyulular duyuru = Db.Duyulular.Find(id);
            if (duyuru == null)
            {
                return HttpNotFound();
            }

            Db.Duyulular.Remove(duyuru);
            Db.SaveChanges();
            return RedirectToAction("Duyulular");
        
    }

        public ActionResult Etkinlik()
        {


            return View(Db.Etkinlik.ToList());
        }
        public ActionResult EtkinlikAdd()
        {


            return View();
        }
        [HttpPost]
        public ActionResult EtkinlikAdd( etkinlik model)
        {
            if (model != null)
            {

                model.Blogerid = Convert.ToInt32(Session["ID"]);
                model.Time = DateTime.Now;
                model.Updatetime = DateTime.Now;
                Db.Etkinlik.Add(model);
                Db.SaveChanges();
            }

            return RedirectToAction("Etkinlik");
        }
        public ActionResult EtkinlikDelete(int?id)
        {

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            etkinlik model = Db.Etkinlik.Find(id);
            if (model == null)
            {
                return HttpNotFound();
            }

            Db.Etkinlik.Remove(model);
            Db.SaveChanges();
            return RedirectToAction("Etkinlikler");

        }
        public ActionResult Slideradd()
        {
            return View();
        }

        //slider
        [HttpPost]
        public ActionResult Slideradd(sliderview model)
        {
           
            slider item = new slider();
             
            if(model.İmg !=null)
            {
                model.İmg.SaveAs(Server.MapPath("~/Imj/slider/") + model.İmg.FileName);

            }

            if (ModelState.IsValid)
            {
                item.Title = model.Title;
                item.Yazi = model.Yazi;
                item.Updatetime = DateTime.Now;
                item.Description = model.Description;
                
                item.İmg = "/Imj/slider/" + model.İmg.FileName;
                Db.Slider.Add(item);
                Db.SaveChanges();
                return RedirectToAction("slider");
            }
        
            return View("blogger");
        }

    



        public ActionResult slider()
        {
            return View(Db.Slider.ToList());

        }

        public ActionResult sliderEdit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            slider slider = Db.Slider.Find(id);
            if (slider == null)
            {
                return HttpNotFound();
            }
            return View(slider);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult sliderEdit([Bind(Include = "ID,İmg,Title,Description,Yazi,Updatetime")] slider slider)
        {
            if (ModelState.IsValid)
            {
                Db.Entry(slider).State = EntityState.Modified;
                Db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(slider);
        }

        public ActionResult sliderDelete(int? id)
        

        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            slider slider = Db.Slider.Find(id);
            if (slider == null)
            {
                return HttpNotFound();
            }

            Db.Slider.Remove(slider);
            Db.SaveChanges();
            return RedirectToAction("slider");
        }

        //end slider

            //category
        public ActionResult category()
        {

            return View(Db.Category.ToList());
        }
        public ActionResult categoryadd()
        {
            return View();
        }
        [HttpPost]
        public ActionResult categoryadd(category model)
        {
            category item = new category();

            if (ModelState.IsValid)
            {

                item.Categoryname = model.Categoryname;



                Db.Category.Add(item);
                Db.SaveChanges();
                return RedirectToAction("category");
            };

            return View();
        }

        public ActionResult categoryDelete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            category category = Db.Category.Find(id);
            if (category == null)
            {
                return HttpNotFound();
            }

            Db.Category.Remove(category);
            Db.SaveChanges();
            return RedirectToAction("category");
        }
        public  ActionResult categorydetail(int? id)
        {
            category category = new category();
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            category = Db.Category.Find(id);

            ICollection<blogger> bloggers= category.Bloggers.ToList();

            return View(bloggers);
        }



        // GET: bloggers
        public ActionResult Index()
        {
          
            return View(Db.Blogger.ToList());
        }

        // GET: bloggers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            blogger blogger = Db.Blogger.Find(id);
            if (blogger == null)
            {
                return HttpNotFound();
            }
            return View(blogger);
        }

        // GET: bloggers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: bloggers/Create
        // Aşırı gönderim saldırılarından korunmak için, lütfen bağlamak istediğiniz belirli özellikleri etkinleştirin, 
        // daha fazla bilgi için https://go.microsoft.com/fwlink/?LinkId=317598 sayfasına bakın.
        [HttpPost]
        
        public ActionResult Create( createview model)
        { blogger blogger = new blogger();
            if (model.file!= null)
            {
                //Sunucuya dosya kaydedilirken, sunucunun dosya sistemini, yolunu bilemeyeceğimiz için
                //Server.MapPath() ile sitemizin ana dizinine gelmiş oluruz. Devamında da sitemizdeki
                //yolu tanımlarız.
                model.file.SaveAs(Server.MapPath("~/Imj/") + model.file.FileName);
              
               
            }
            

            if (ModelState.IsValid)
            {
                blogger.Name = model.Name;
                blogger.Email = model.email;
                blogger.Cv = model.cv;
                blogger.Description = model.description;
                blogger.Username = model.username;
                blogger.Password = model.password;
                blogger.İmg = model.file.FileName;
                blogger.Createtime = DateTime.Now;
                blogger.Lastaktivetime = DateTime.Now;
                
               Db.Blogger.Add(blogger);
                Db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(blogger);
        }
       

        // GET: bloggers/Edit/5
        public ActionResult Edit(int? id)
        {
            
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            blogger blogger = Db.Blogger.Find(id);
            if (blogger == null)
            {
                return HttpNotFound();
            }
           
            return View(blogger);
        }

        // POST: bloggers/Edit/5
        // Aşırı gönderim saldırılarından korunmak için, lütfen bağlamak istediğiniz belirli özellikleri etkinleştirin, 
        // daha fazla bilgi için https://go.microsoft.com/fwlink/?LinkId=317598 sayfasına bakın.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,imjurl,cv,Name,username,password,email,createtime,lastaktivetime,description")] blogger blogger)
        {
            if (ModelState.IsValid)
            {
                Db.Entry(blogger).State = EntityState.Modified;
                Db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(blogger);
        }

        // GET: bloggers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            blogger blogger = Db.Blogger.Find(id);
            if (blogger == null)
            {
                return HttpNotFound();
            }
            return View(blogger);
        }

        //Giris
        public ActionResult Login()
        {
           
               Loginview login = new Loginview();
            ViewBag.ReturnUrl = "/Home/Index";
            login.Category = Db.Category.ToList();
            return View(login);
        }
        [HttpPost]
        public ActionResult Login(Loginview model)
        {
            foreach (var Blogers in Db.Blogger)
            {

                if (Blogers.Username == model.bloggers.Username && Blogers.Password == model.bloggers.Password)
                {
                    Session["username"] = Blogers.Username;

                    Session["ID"] = Blogers.ID.ToString();
                    
                    
                }


            }



                if (model.bloggers.Username == "hakan")
                {
                    Session["Admin"] = model.bloggers.Username.ToString();
                }
                else
            { Session["Admin"] = null;
          

           
                return RedirectToAction("Create", "bloggers");
            }
            return RedirectToAction("Index", "Home");

        }
        public ActionResult cikis()
        {
            
            Session["SessionID"] = null;
            Session["Admin"] = null;
            Session["username"] = null;
            return RedirectPermanent("/Home/Index");

        }

       // POST: bloggers/Delete/5
       [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            blogger blogger = Db.Blogger.Find(id);
            Db.Blogger.Remove(blogger);
            Db.SaveChanges();
            return RedirectToAction("Index");
        }



        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                Db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
