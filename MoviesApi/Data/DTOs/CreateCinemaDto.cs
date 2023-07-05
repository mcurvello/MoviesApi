using System;
using System.ComponentModel.DataAnnotations;

namespace MoviesApi.Data.DTOs
{
	public class CreateCinemaDto
	{
        [Required(ErrorMessage = "The name field is required")]
        public string Name { get; set; }

        public int AddressId { get; set; }
    }
}
