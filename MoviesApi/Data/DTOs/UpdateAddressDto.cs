using System;
using System.ComponentModel.DataAnnotations;

namespace MoviesApi.Data.DTOs
{
	public class UpdateAddressDto
	{
        public string StreetLine { get; set; }

        public int Number { get; set; }
    }
}

