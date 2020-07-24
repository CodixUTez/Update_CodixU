using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web;

namespace codixU.Models.Entities
{
    [Table("Users")]
    public class Users
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required(ErrorMessage = "İsim alanı zorunludur.")]
        [Display(Name = "İsim")]
        [MaxLength(20, ErrorMessage = "İsim alanı en fazla 20 karakter olabilir.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Soyisim alanı zorunludur.")]
        [Display(Name = "Soyisim")]
        [MaxLength(20, ErrorMessage = "Soyisim alanı en fazla 20 karakter olabilir.")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Email adresi zorunludur.")]
        [Display(Name = "Email Adresi")]
        [MaxLength(200, ErrorMessage = "Email alanı en fazla 200 karakter olabilir.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Şifre alanı zorunludur.")]
        [Display(Name = "Şifre")]
        [MaxLength(20, ErrorMessage = "Şifre alanı en fazla 20 karakter olabilir.")]
        [MinLength(6, ErrorMessage = "Şifre en az 6 karakter olmalı.")]
        public string Password { get; set; }

        [NotMapped]
        [Required(ErrorMessage = "Bu alan boş geçilemez.")]
        [CompareAttribute("Password", ErrorMessage = "Şifre eşleşmiyor.")]
        public string ConfirmPassowrd { get; set; }
        public bool algorithm { get; set; }
        public int score { get; set; }

        private ICollection<Roles> _roles;

        public virtual ICollection<Roles> Roles
        {
            get { return _roles ?? (_roles = new HashSet<Roles>()); }
            protected set { _roles = value; }
        }

        public virtual ICollection<Interactive> _interactive { get; set; }
        public virtual ICollection<Courses> _courses { get; set; }
    }
}