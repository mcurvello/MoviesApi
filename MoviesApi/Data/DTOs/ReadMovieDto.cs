using System;
using System.ComponentModel.DataAnnotations;

namespace MoviesApi.Data.DTOs
{
	public class ReadMovieDto
	{
        public string Title { get; set; }

        public string Genre { get; set; }

        public int Duration { get; set; }

        public DateTime TimeOfGet { get; set; } = DateTime.Now;
    }
}
