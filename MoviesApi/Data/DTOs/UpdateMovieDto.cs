﻿using System;
using System.ComponentModel.DataAnnotations;

namespace MoviesApi.Data.DTOs
{
	public class UpdateMovieDto
    {
        [Required(ErrorMessage = "The movie title is required")]
        public string Title { get; set; }

        [Required(ErrorMessage = "The movie genre is required")]
        [StringLength(50, ErrorMessage = "The genre length has a maximum length of 50")]
        public string Genre { get; set; }

        [Required]
        [Range(70, 600, ErrorMessage = "The duration must have between 70 and 600 minutes")]
        public int Duration { get; set; }
    }
}

