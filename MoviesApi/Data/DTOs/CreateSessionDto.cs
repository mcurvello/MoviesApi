﻿using System;
namespace MoviesApi.Data.DTOs
{
	public class CreateSessionDto
	{
		public int MovieId { get; set; }

        public int CinemaId { get; set; }
    }
}
