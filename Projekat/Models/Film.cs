using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Projekat.Models
{
    public class Film
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Title")]
        [StringLength(150)]
        public string Title { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy - MM - dd}", ApplyFormatInEditMode = true)]
        public DateTime ReleaseDate { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        [Required]
        [Display(Name = "Director")]
        [StringLength(100)]
        public string Director { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        [Required]
        [Display(Name = "Genres")]
        [StringLength(100)]
        public string Genres { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        [Required]
        [Display(Name = "Country")]
        [StringLength(100)]
        public string Country { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        [Required]
        [Display(Name = "Language")]
        [StringLength(30)]
        public string Language { get; set; }
    }
}