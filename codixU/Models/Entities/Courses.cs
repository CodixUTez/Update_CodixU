using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web;

namespace codixU.Models.Entities
{
    [Table("Courses")]
    public class Courses
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string xml { get; set; }
        public string tags { get; set; }
        public DateTime creaateDate { get; set; }
        public Interactive Interactive { get; set; }
        public virtual ICollection<Users> _users { get; set; }
        


    }
}