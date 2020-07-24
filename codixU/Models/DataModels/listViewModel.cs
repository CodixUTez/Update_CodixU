using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Demo.Helper.External.Models;

namespace codixU.Models.DataModels
{
    public class ListViewModel
    {
        public IList<Educations> Educations { get; set; }
        public List<Educations> RetrunListOfEducations { get; set; }
        public List<Educations> ReturnListOfInfo { get; set; }
        public List<Educations> ReturnListOfCodes { get; set; }
        public List<Educations> RetrunListOfInteractiveInfo { get; set; }
        public List<Educations> RetrunListOfInteractiveEducations { get; set; }


    }
}