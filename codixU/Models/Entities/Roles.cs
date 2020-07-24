using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web;

namespace codixU.Models.Entities
{
    [Table("Roles")]
    public class Roles
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        [MaxLength(20)]
        public string RoleName { get; set; }

        private ICollection<Users> _users;

        public virtual ICollection<Users> Users
        {
            get { return _users ?? (_users = new HashSet<Users>()); }
            protected set { _users = value; }
        }
    }
}