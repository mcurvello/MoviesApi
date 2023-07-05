using System;
using System.ComponentModel.DataAnnotations;

namespace MoviesApi.Models
{
	public class Address
	{
        [Key]
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "The street line field is required")]
        public string StreetLine { get; set; }

        [Required(ErrorMessage = "The number field is required")]
        public int Number { get; set; }

        public virtual Cinema Cinema { get; set; }
    }
}
