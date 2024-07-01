using CrudMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CrudMVC.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        sqlhelper sql = new sqlhelper();

        public ActionResult Index()
        {
            List<student> students = new List<student>();   
            return View(students);
        }
    }
}