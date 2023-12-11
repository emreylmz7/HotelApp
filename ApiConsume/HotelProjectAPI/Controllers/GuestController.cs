using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelProject.BusinessLayer.Abstract;
using HotelProject.DtoLayer.Dtos.RoomDto;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace HotelProjectAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GuestController : ControllerBase
    {
        private readonly IGuestService _guestService;
        public GuestController(IGuestService guestService)
        {
            _guestService = guestService;
        }


        [HttpGet]
        public IActionResult GuestList()
        {
            var values = _guestService.TGetList();
            return Ok(values);
        }

        [HttpGet("GuestCount")]
        public IActionResult GuestCount()
        {
            var values = _guestService.TGetGuestCount();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddGuest(Guest guest)
        {
            _guestService.TInsert(guest);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteGuest(int id)
        {
            var value = _guestService.TGetById(id);
            _guestService.TDelete(value);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateGuest(Guest guest)
        {
            _guestService.TUpdate(guest);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetGuest(int id)
        {
            var value = _guestService.TGetById(id);
            return Ok(value);
        }
    }
}