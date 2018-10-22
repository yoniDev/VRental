using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.AccessControl;
using System.Web;

namespace VRental.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        
        public Models.Genre Genre { get; set; }

        [Required]
        [Display(Name = "Genre")]
        public byte GenreId { get; set; }

        [Required]
        [Display(Name = "Released Date")]
        public DateTime ReleasedDate { get; set; }

        public DateTime AddedDate { get; set; }

        
        [Display(Name = "Numbers in Stock")]
        public byte NumbersInStock { get; set; }
    }
    
}