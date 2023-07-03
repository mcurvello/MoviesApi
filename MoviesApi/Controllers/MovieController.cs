using System;
using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MoviesApi.Data;
using MoviesApi.Data.DTOs;
using MoviesApi.Models;

namespace MoviesApi.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class MovieController : ControllerBase
	{
		private MovieContext _context;
		private IMapper _mapper;

        public MovieController(MovieContext context, IMapper mapper)
        {
            _context = context;
			_mapper = mapper;
        }

        [HttpPost]
		public IActionResult AddMovie([FromBody] CreateMovieDto movieDto)
		{
			Movie movie = _mapper.Map<Movie>(movieDto);

			_context.Movies.Add(movie);
			_context.SaveChanges();
			return CreatedAtAction(nameof(GetMovieById), new {id = movie.Id}, movie);
        }

		[HttpGet]
		public IActionResult GetAllMovies([FromQuery] int skip = 0, [FromQuery] int take = 50)
		{
            return Ok(_context.Movies.Skip(skip).Take(take));
		}

        [HttpGet("{id}")]
        public IActionResult GetMovieById(int id)
        {
			var movie = _context.Movies.FirstOrDefault(movie => movie.Id == id);
			if (movie == null) return NotFound();
			return Ok(movie);
        }
    }
}
