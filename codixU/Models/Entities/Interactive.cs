using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web;

namespace codixU.Models.Entities
{
    [Table("Interactive")]
    public class Interactive
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string name { get; set; }
        public ICollection<Quizzes> _quizzes { get; set; }
        public virtual ICollection<Courses> _courses { get; set; }
        public virtual ICollection<Users> _users { get; set; }


        
    }
}