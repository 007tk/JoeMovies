using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace JoeMovies.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        
        [Display(Name = "Release Date")]
        [Required]
        public DateTime ReleaseDate { get; set; }

        
        public DateTime DateAdded { get; set; }

        [Required]
        [Display(Name = "Number In Stock")]
        [Range(1,20, ErrorMessage = "Number In stock should be between 1 and 20.")]
        public int NumberInStock { get; set; }

        public int NumberAvailable { get; set; }

        public Genre Genre { get; set; }

        [Display(Name = "Genre")]
        [Required]
        public byte GenreId { get; set; }
    }
}