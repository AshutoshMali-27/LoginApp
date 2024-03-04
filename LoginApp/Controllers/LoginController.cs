using LoginApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LoginApp.Controllers
{
 
    public class LoginController : Controller
    {
        LoginDBEntities3 db = new LoginDBEntities3();
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Logout()
        {
            Session.Abandon();
            return RedirectToAction("Index", "Login");
        }
        public ActionResult Reset()
        {
            ModelState.Clear();
            return RedirectToAction("Index", "Login");
        }
        

        [HttpPost]
        public ActionResult Index( user s)
        {
            if(ModelState.IsValid == true)
            {
               var Credential = db.users.Where(model => model.username == s.username && model.password == s.password).FirstOrDefault();
               if(Credential == null)
               {
                   ViewBag.ErrorMessage = "Login Failed";
                   return View();
               }
               else
               {
                   Session["username"] = s.username;
                   return RedirectToAction("Index", "Home");
                }
           // 
             }
            return View();

        }
    }
}