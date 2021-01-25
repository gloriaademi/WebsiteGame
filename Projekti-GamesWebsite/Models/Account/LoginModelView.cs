using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Projekti_GamesWebsite.Models
{
    public class LoginModelView
    {
        [Required]
        public string Name { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Display(Name="Remember me?")]
        public string Error { get; set; }
        public bool RememberMe { get; set; }

    }
}