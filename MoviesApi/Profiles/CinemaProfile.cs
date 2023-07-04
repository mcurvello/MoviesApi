﻿using System;
using AutoMapper;
using MoviesApi.Data.DTOs;
using MoviesApi.Models;

namespace MoviesApi.Profiles
{
	public class CinemaProfile : Profile
	{
		public CinemaProfile()
		{
            CreateMap<CreateCinemaDto, Cinema>();
            CreateMap<UpdateCinemaDto, Cinema>();
            CreateMap<Cinema, ReadCinemaDto>();
        }
	}
}

