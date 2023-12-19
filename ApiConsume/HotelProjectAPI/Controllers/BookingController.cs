using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace HotelProjectAPI.Controllers
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


        [HttpGet]
        public IActionResult BookingList()
        {
            var values = _bookingService.TGetList();
            return Ok(values);
        }

        [HttpGet("BookingCount")]
        public IActionResult BookingCount()
        {
            var values = _bookingService.TGetBookingCount();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddBooking(Booking booking)
        {
            _bookingService.TInsert(booking);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteBooking(int id)
        {
            var value = _bookingService.TGetById(id);
            _bookingService.TDelete(value);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateBooking(Booking booking)
        {
            _bookingService.TUpdate(booking);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetBooking(int id)
        {
            var value = _bookingService.TGetById(id);
            return Ok(value);
        }

        [HttpGet("ApprovedBooking")]
        public IActionResult ApprovedBooking(int id)
        {
            _bookingService.TBookingStatusChangeApproved(id);
            return Ok();
        }
        [HttpGet("CanceledBooking")]
        public IActionResult CanceledBooking(int id)
        {
            _bookingService.TBookingStatusChangeCancel(id);
            return Ok();
        }
        [HttpGet("PendingBooking")]
        public IActionResult PendingBooking(int id)
        {
            _bookingService.TBookingStatusChangePending(id);
            return Ok();
        }
    }
}