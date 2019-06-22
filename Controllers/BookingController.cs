using BookingBossApi.Models;
using BookingBossApi.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BookingBossApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly BookingService _bookingService;

        public BookingController(BookingService bookingService)
        {
            _bookingService = bookingService;
        }

        [HttpGet]
        public ActionResult<List<BookingModel>> Get() =>
            _bookingService.Get();

        [HttpGet("{id:length(24)}", Name = "GetBooking")]
        public ActionResult<BookingModel> Get(string id)
        {
            var booking = _bookingService.Get(id);

            if (booking == null)
            {
                return NotFound();
            }

            return booking;
        }

        [HttpPost]
        public ActionResult<BookingModel> Create(BookingModel booking)
        {
            _bookingService.Create(booking);

            return CreatedAtRoute("GetBooking", new { id = booking.Id.ToString() }, booking);
        }

        [HttpPut("{id:length(24)}")]
        public IActionResult Update(string id, BookingModel bookingIn)
        {
            var booking = _bookingService.Get(id);

            if (booking == null)
            {
                return NotFound();
            }

            _bookingService.Update(id, bookingIn);

            return NoContent();
        }

        [HttpDelete("{id:length(24)}")]
        public IActionResult Delete(string id)
        {
            var booking = _bookingService.Get(id);

            if (booking == null)
            {
                return NotFound();
            }

            _bookingService.Remove(booking.Id);

            return NoContent();
        }
    }
}