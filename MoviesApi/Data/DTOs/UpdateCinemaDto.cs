using System;
using System.ComponentModel.DataAnnotations;

namespace MoviesApi.Data.DTOs
{
	public class UpdateCinemaDto
	{
        [Required(ErrorMessage = "The name field is required")]
        public string Name { get; set; }
    }
}
