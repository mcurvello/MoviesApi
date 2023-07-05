using System;
using System.ComponentModel.DataAnnotations;

namespace MoviesApi.Data.DTOs
{
	public class ReadAddressDto
	{
        public int Id { get; set; }

        public string StreetLine { get; set; }

        public int Number { get; set; }
    }
}

