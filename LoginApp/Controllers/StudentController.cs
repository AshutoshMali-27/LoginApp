using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LoginApp.Models;

namespace LoginApp.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        LoginDBEntities3 db = new LoginDBEntities3();
        public ActionResult Index()
        {
            return View();
        }
    }
}