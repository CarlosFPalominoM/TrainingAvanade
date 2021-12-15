using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Training.Application.Booking;

namespace Training.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BookingController : ControllerBase
    {
        private readonly IBookingService _bookingService;

        public BookingController(IBookingService bookingService)
        {
            _bookingService = bookingService;
        }

        [HttpGet("{dni}")]
        public IActionResult GetBookingsByUser(string dni)
        {
            var bookings = _bookingService.GetForUser(dni);

            return Ok(bookings);
        }

        [HttpDelete]
        public IActionResult Delete(string isbn, string dni)
        {
            _bookingService.Delete(isbn, dni);

            return Ok();
        }

        [HttpPut]
        public IActionResult Put(BookingDto booking)
        {
            _bookingService.Update(booking);

            return Ok();
        }

        [HttpPost]
        public IActionResult Post(BookingDto booking)
        {
            _bookingService.Create(booking);

            return Ok();
        }
    }
}
