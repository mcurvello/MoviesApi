using System;
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
		public void AddMovie([FromBody] Movie movie)
		{
			movie.Id = id++;
			movies.Add(movie);
        }

		[HttpGet]
		public IEnumerable<Movie> GetAllMovies([FromQuery] int skip = 0, [FromQuery] int take = 50)
		{
			return movies.Skip(skip).Take(take);
		}

        [HttpGet("{id}")]
        public Movie? GetMovieById(int id)
        {
			return movies.FirstOrDefault(movie => movie.Id == id);
        }
    }
}
