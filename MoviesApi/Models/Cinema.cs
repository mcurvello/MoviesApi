using System;
using System.ComponentModel.DataAnnotations;

namespace MoviesApi.Models
{
	public class Cinema
	{
		[Key]
		[Required]
		public int Id { get; set; }

		[Required(ErrorMessage = "The name field is required")]
		public string Name { get; set; }
	}
}
