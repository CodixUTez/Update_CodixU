using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Demo.Helper.External.Models
{
    [Serializable]
    [XmlRoot("Educations"), XmlType("Educations")]
    public class Educations
    {
        public string Writer { get; set; }
        public string About { get; set; }
        public string Tag { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string content1 { get; set; }
        public string Code { get; set; }
        public string Id { get; set; }

        public string Description { get; set; }
        public string EducationTitle { get; set; }
        public string EducationContent { get; set; }


    }
    
}
