using System;
using System.ComponentModel.DataAnnotations;

namespace MoviesApi.Models
{
	public class Session
	{
        [Key]
        [Required]
        public int Id { get; set; }
    }
}

