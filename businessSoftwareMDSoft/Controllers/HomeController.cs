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
        //[Authorize(SYSUser(Logi))]
        //[Authorize]
        public ActionResult Index(SYSUser model)
        {
            return View();
        }
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login", "Account");
        }
    }
}