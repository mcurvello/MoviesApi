using System;
using Microsoft.EntityFrameworkCore;
using MoviesApi.Models;

namespace MoviesApi.Data
{
	public class MovieContext: DbContext
	{
		public MovieContext(DbContextOptions<MovieContext> options) : base(options)
		{
		}

		public DbSet<Movie> Movies { get; set; }
		public DbSet<Cinema> Cinemas { get; set; }
	}
}

