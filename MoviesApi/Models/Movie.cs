using System;
using System.ComponentModel.DataAnnotations;

namespace MoviesApi.Models
{
	public class Movie
	{
        [Key]
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "The movie title is required")]
		public string Title { get; set; }

        [Required(ErrorMessage = "The movie genre is required")]
		[MaxLength(50, ErrorMessage = "The genre length has a maximum length of 50")]
        public string Genre { get; set; }

		[Required]
		[Range(70, 600, ErrorMessage = "The duration must have between 70 and 600 minutes")]
        public int Duration { get; set; }
    }
}

