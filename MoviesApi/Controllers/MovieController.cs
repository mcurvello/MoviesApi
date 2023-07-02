using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MoviesApi.Models;

namespace MoviesApi.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class MovieController : ControllerBase
	{
		private static List<Movie> movies = new List<Movie>();
		private static int id = 0;

		[HttpPost]
		public IActionResult AddMovie([FromBody] Movie movie)
		{
			movie.Id = id++;
			movies.Add(movie);
			return CreatedAtAction(nameof(GetMovieById), new {id = movie.Id}, movie);
        }

		[HttpGet]
		public IActionResult GetAllMovies([FromQuery] int skip = 0, [FromQuery] int take = 50)
		{
			if (movies.Count == 0) return NoContent();

            return Ok(movies.Skip(skip).Take(take));
		}

        [HttpGet("{id}")]
        public IActionResult GetMovieById(int id)
        {
			var movie = movies.FirstOrDefault(movie => movie.Id == id);
			if (movie == null) return NotFound();
			return Ok(movie);
        }
    }
}
