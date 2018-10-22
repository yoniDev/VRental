using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using VRental.Models;

namespace VRental.ViewModels
{
    public class MovieFormViewModel
    {
        public IEnumerable<Genre> Genres { get; set; }
        public int? Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Genre")]
        public byte? GenreId { get; set; }

        [Required]
        [Display(Name = "Released Date")]
        public DateTime? ReleasedDate { get; set; }

        [Required]
        [Range(1, 20)]
        [Display(Name = "Numbers in Stock")]
        public byte? NumbersInStock { get; set; }


        public MovieFormViewModel()
        {
            Id = 0;
        }

        public MovieFormViewModel(Movie movie)
        {
            Id = movie.Id;
            Name = movie.Name;
            ReleasedDate = movie.ReleasedDate;
            NumbersInStock = movie.NumbersInStock;
            GenreId = movie.GenreId;

        }
        public string Title
        {
            get
            {
                return Id != 0 ? "New Movie" : "Edit Movie";
            }

        }
    }
}