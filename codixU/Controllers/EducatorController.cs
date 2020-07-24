using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace codixU.Controllers
{
    public class EducatorController : Controller
    {
        // GET: Educator
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult XmlAdd()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Upload()
        {
            string a = "";
            string xmlData = HttpContext.Server.MapPath("~/App_Data2/");//Path of the xml script  
            for (int i = 0; i < HttpContext.Request.Files.Count; i++)
            {
                 HttpPostedFileBase upload = HttpContext.Request.Files[i];

                string filename = Server.MapPath("~/App_Data2") + "\\" + upload.FileName;
                upload.SaveAs(filename);

            }
            return Content(a);
        }
        [HttpPost]
        public FileResult Download()
        {
            string fileName = "EmptyXml.xml";
            byte[] fileBytes = System.IO.File.ReadAllBytes(Server.MapPath("~/App_Data2/") + "\\"+fileName);
            return File(fileBytes, System.Net.Mime.MediaTypeNames.Application.Octet, fileName);
        }
    
    }
}