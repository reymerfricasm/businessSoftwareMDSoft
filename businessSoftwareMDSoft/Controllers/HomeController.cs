using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;
using businessSoftwareMDSoft.Models;
using System.Web.Security;
namespace businessSoftwareMDSoft.Controllers
{
    public class HomeController : Controller
    {
        //[Authorize(Users = "Reymer")]
        //[Authorize(Roles = "Administrador")]
        public ActionResult Index(SYSUser model)
        {
            if (model.isActive != "0")
            {
                BSEntities db = new BSEntities();
                List<SYSUser> use;
                use = db.SYSUser.Find(model.isActive);
                if (ModelState.IsValid)
                {
                    

                }
            }
            
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}