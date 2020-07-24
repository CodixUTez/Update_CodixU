using Demo.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using codixU.Models.DataModels;


namespace codixU.Controllers
{
    public class EducationListController : Controller
    {
        // GET: EducationList
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult EducationView()
        {
            XmlReader readXML = new XmlReader();
            var viewModel = new ListViewModel
            {

                RetrunListOfEducations = readXML.RetrunListOfEducations(),
                ReturnListOfInfo = readXML.RetrunListOfInfo(),
                ReturnListOfCodes = readXML.RetrunListOfCodes(),
                RetrunListOfInteractiveInfo = readXML.RetrunListOfInteractiveInfo(),
                RetrunListOfInteractiveEducations = readXML.RetrunListOfInteractiveEducations()
            };
            return View(viewModel);
        }

        public ActionResult InteractiveEducation()
        {
            XmlReader readXML = new XmlReader();
            var viewModel = new ListViewModel
            {

                RetrunListOfEducations = readXML.RetrunListOfEducations(),
                ReturnListOfInfo = readXML.RetrunListOfInfo(),
                ReturnListOfCodes = readXML.RetrunListOfCodes(),
                RetrunListOfInteractiveInfo = readXML.RetrunListOfInteractiveInfo(),
                RetrunListOfInteractiveEducations = readXML.RetrunListOfInteractiveEducations()
            };
            return View(viewModel);

        }
    }
}