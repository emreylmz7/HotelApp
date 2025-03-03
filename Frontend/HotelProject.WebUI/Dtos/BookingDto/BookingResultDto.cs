using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.WebUI.Dtos.BookingDto
{
    public class BookingResultDto
    {
        public int BookingID { get; set; }
        public string? Name { get; set; }
        public string? Mail { get; set; }
        public string? City { get; set; }
        public string? Country { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public string? AdultCount { get; set; }
        public string? ChildCount { get; set; }
        public string? RoomCount { get; set; }
        public string? SpecialRequest { get; set; }
        public string? Description { get; set; }
        public BookingStatus? Status { get; set; }
    }
}