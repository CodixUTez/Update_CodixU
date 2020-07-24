using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Antlr.Runtime.Misc;
using codixU.Manager;

namespace codixU.Controllers
{

    
    public class StudentController : Controller
    {


        // GET: Student
        [Authorization]
        public ActionResult StudentHome()
        {

            return View("~/Views/User/Student/StudentHome.cshtml");
        }
        [Authorization(Permission ="Admin,Student")]
        public ActionResult StudentEducator()
        {
            return View("~/Views/User/Student/StudentEducator.cshtml");
        }
        [Authorization]
        public ActionResult StudentProfile()
        {
            return View("~/Views/User/Student/StudentProfile.cshtml");
        }
        [Authorization]
        public ActionResult StudentCourses()
        {
            return View("~/Views/User/Student/StudentCourses.cshtml");
        }
        public ActionResult EduType()
        {
            return View("~/Views/User/Student/EduType.cshtml");
        }
    }
}