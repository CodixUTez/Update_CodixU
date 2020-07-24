using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace codixU.Models.Entities
{
    [Table("Quizzes")]
    public class Quizzes
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string name { get; set; }
        public Interactive Interactive { get; set; }
        public virtual ICollection<Questions> _questions { get; set; }
        

    }
}