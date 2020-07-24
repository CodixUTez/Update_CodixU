using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web;

namespace codixU.Models.Entities
{
    [Table("Questions")]
    public class Questions
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string question { get; set; }
        public string? Image { get; set; }
        public string optionA { get; set; }
        public string optionB { get; set; }
        public string optionC { get; set; }
        public string optionD { get; set; }
        public string answer { get; set; }
        public Quizzes Quizzes { get; set; }
        

    }
}