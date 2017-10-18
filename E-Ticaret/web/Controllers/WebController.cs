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
    public class WebController : Controller
    {
        ProductService product = new ProductService();
        CategoryService Category = new CategoryService();
        // GET: Web
        public ActionResult Index()
        {


            IList<CategoryListODT> categorylist = Category.GetAll();
            ViewBag.categorylist = categorylist;
            
            IList<ProductlistDTO> productlist = product.GetAll();

            
            return View(productlist);
        }

        public ActionResult category(int? id)
        {


            ViewBag.categorylist= Category.GetAll();

            return View(product.GetAll((int)id));
        }

    }
}