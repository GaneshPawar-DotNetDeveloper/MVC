using CrudOPerationUsingMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CrudOPerationUsingMVC.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student

        // here i want to show list of student

        // so our property,logic are declared in StudentDbHelper
        // so we create the object

        

        public ActionResult Index()
        {
            StudentDbHelper db = new StudentDbHelper();
            List<StudentProperty> st = db.StudentDetail();

            return View(st);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
    }
}