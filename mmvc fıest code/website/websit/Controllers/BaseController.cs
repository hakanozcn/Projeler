using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;



namespace websit.Controllers
{
    
    
    
    public class BaseController : Controller
    {
        





        protected override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            string controller = filterContext.RouteData.Values["controller"].ToString();
            string view = filterContext.RouteData.Values["Action"].ToString();

            if (Session["username"] != null && Session["Admin"]!=null )

            { 
                 base.OnActionExecuted(filterContext);
                return;
            
                
            




            }
            else if(Session["username"]!=null&&Session["Admin"]==null)
            {
                if (controller == "Home"||view=="Login")
                {
                    base.OnActionExecuted(filterContext);
                    return;
                }
                else
                {
                    filterContext.Result = RedirectToAction("Login", "bloggers");
                }

            }
            else if(Session["username"] == null && Session["Admin"] == null)
            {
                if (controller=="Home")
                {
                    if (view == "makale" || view == "MakaleADD")
                    {
                        filterContext.Result= RedirectToAction("Login", "bloggers");
                        return;
                    }
                    else
                    base.OnActionExecuted(filterContext);
                }
         else   if(controller=="bloggers")
                {if(view=="Login"||view=="Create"||view=="index")
                    {
                        base.OnActionExecuted(filterContext);
                    }
                else
                    filterContext.Result = RedirectToAction("Login", "bloggers");
                    return;

                } 
                else
                    base.OnActionExecuted(filterContext);
            }
        }
        

    }
}