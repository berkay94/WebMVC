using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp2.Models;

namespace WebApp2.Controllers
{
    public class StudentController : Controller
    {
        AppDbContext db = new AppDbContext();
        // GET: Student
        public ActionResult Index()
        {
            return View(db.Students.ToList());
        }
    }
}