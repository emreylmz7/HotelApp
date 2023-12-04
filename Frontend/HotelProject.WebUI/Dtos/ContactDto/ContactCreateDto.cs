using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.WebUI.Dtos.ContactDto
{
    public class ContactCreateDto
    {
        public string? Name { get; set; }
        public string? Mail { get; set; }
        public string? Subject { get; set; }
        public string? Message { get; set; }
        public DateTime Date { get; set; }
        public int MessageCategoryID { get; set; }
    }
}