using System;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MoviesApi.Data;
using MoviesApi.Data.DTOs;
using MoviesApi.Models;

namespace MoviesApi.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class AddressController : ControllerBase
	{
		private MovieContext _context;
		private IMapper _mapper;

        public AddressController(MovieContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult AddAddress([FromBody] CreateAddressDto addressDto)
        {
            Address address = _mapper.Map<Address>(addressDto);
            _context.Addresses.Add(address);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetAddressById), new { Id = address.Id }, addressDto);
        }

        [HttpGet]
        public IActionResult GetAllAdresses()
        {
            return Ok(_mapper.Map<List<ReadAddressDto>>(_context.Addresses));
        }

        [HttpGet("{id}")]
        public IActionResult GetAddressById(int id)
        {
            Address address = _context.Addresses.FirstOrDefault(a => a.Id == id);
            if (address != null)
            {
                ReadAddressDto addressDto = _mapper.Map<ReadAddressDto>(address);
                return Ok(addressDto);
            }
            return NotFound();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateAddress(int id, [FromBody] UpdateAddressDto addressDto)
        {
            Address address = _context.Addresses.FirstOrDefault(a => a.Id == id);

            if (address == null) return NotFound();

            _mapper.Map(addressDto, address);
            _context.SaveChanges();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteAddress(int id)
        {
            Address address = _context.Addresses.FirstOrDefault(a => a.Id == id);

            if (address == null) return NotFound();

            _context.Remove(address);
            _context.SaveChanges();
            return NoContent();
        }
    }
}

