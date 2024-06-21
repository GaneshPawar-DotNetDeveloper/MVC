using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCBasic.Controllers
{
    // [RoutePrefix("ganesh")]
    // [Route("ganesh/home")]
   //  [Route("ganesh/pawar")] // when we write two route attribte then it get with method not class attribute



    public class HomeController : Controller
    {
        // GET: Home
        // here now we  put our url like domain/Home/Welcome
        // but I want my url be like http://localhost23425/ganesh/Home
        // so for that we use Attribute based Routing
        // so apply attributes
        // [Route("Home")]
        //   [Route("ganesh/home")]
        /* public string Welcome(int? Id)
         {
             return "welcome ganesh in MVC. you entered :"+Id;
         }*/

        [HttpGet]
        public ActionResult Welcome(int? Id)
        {
            return View();
        } 
        [HttpPost]
        public ActionResult logIn(string name)
        {
            ViewBag.Name = name;
            return View("~/Views/Home/Welcome.cshtml");
        }
    }
}