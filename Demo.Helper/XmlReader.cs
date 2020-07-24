using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Data;
using Demo.Helper.External.Models;

namespace Demo.Helper
{
    public class XmlReader
    {
        public List<Educations> RetrunListOfInfo()
        {
            string xmlData = HttpContext.Current.Server.MapPath("~/App_Data2/EducationsData.xml");//Path of the xml script  
            DataSet ds = new DataSet();//Using dataset to read xml file  
            ds.ReadXml(xmlData);
            var info = new List<Educations>();
            info = (from rows in ds.Tables[0].AsEnumerable()
                    select new Educations
                    {
                        Writer = rows[0].ToString(),
                        About = rows[1].ToString(),
                        Tag = rows[2].ToString(),

                    }).ToList();
            return info;
        }
        public List<Educations> RetrunListOfEducations()
        {
            string xmlData = HttpContext.Current.Server.MapPath("~/App_Data2/EducationsData.xml");//Path of the xml script  
            DataSet ds = new DataSet();//Using dataset to read xml file  
            ds.ReadXml(xmlData);
            var educations = new List<Educations>();
            educations = (from rows in ds.Tables[1].AsEnumerable()
                          select new Educations
                          {
                              Title = rows[0].ToString(),
                              Content = rows[1].ToString(),
                          }).ToList();
            return educations;
        }

        public List<Educations> RetrunListOfCodes()
        {
            string xmlData = HttpContext.Current.Server.MapPath("~/App_Data2/EducationsData.xml");//Path of the xml script  
            DataSet ds = new DataSet();//Using dataset to read xml file  
            ds.ReadXml(xmlData);
            var codes = new List<Educations>();
            codes = (from rows in ds.Tables[2].AsEnumerable()
                     select new Educations
                     {
                         Id = rows[0].ToString(),
                         Code = rows[1].ToString(),
                     }).ToList();
            return codes;
        }
        public List<Educations> RetrunListOfInteractiveInfo()
        {
            string xmlData = HttpContext.Current.Server.MapPath("~/App_Data2/interactiveEducationData.xml");//Path of the xml script  
            DataSet ds = new DataSet();//Using dataset to read xml file  
            ds.ReadXml(xmlData);
            var info2 = new List<Educations>();
            info2 = (from rows in ds.Tables[0].AsEnumerable()
                    select new Educations
                    {
                        Title = rows[0].ToString(),
                        Description = rows[1].ToString(),

                    }).ToList();
            return info2;
        }
        public List<Educations> RetrunListOfInteractiveEducations()
        {
            string xmlData = HttpContext.Current.Server.MapPath("~/App_Data2/interactiveEducationData.xml");//Path of the xml script  
            DataSet ds = new DataSet();//Using dataset to read xml file  
            ds.ReadXml(xmlData);
            var educations = new List<Educations>();
            educations = (from rows in ds.Tables[1].AsEnumerable()
                          select new Educations
                          {
                              EducationTitle = rows[0].ToString(),
                              EducationContent = rows[1].ToString(),
                          }).ToList();
            return educations;
        }
    }
}
