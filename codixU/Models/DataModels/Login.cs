using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace codixU.Models.DataModels
{
    public class Login
    {
        [Required(ErrorMessage = "Email alanı zorunludur.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Şifre alanı zorunludur.")]
        public string Password { get; set; }

        public string ErrorMessage { get; set; }
    }
}
