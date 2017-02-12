using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Projekat.Models
{
    public class User
    {
        public int Id { get; set; }

        [EmailAddress]
        [Required]
        [Display(Name = "Name")]
        [StringLength(50)]
        public string UserName { get; set; }

        [Required]
        [Display(Name = "Password")]
        [StringLength(50)]
        public string Password { get; set; }

        [Display(Name = "Registration Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy - MM - dd}", ApplyFormatInEditMode = true)]
        public DateTime RegistrationDate { get; set; }
    }
}