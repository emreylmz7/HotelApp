using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.WebUI.Dtos.AppUserDto
{
    public class ResultAppUserDto
    {
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? Gender { get; set; }
        public string? Country { get; set; }
        public string? City { get; set; }
        public string? ImageUrl { get; set; }
        public string? WorkDepartmant { get; set; }
        public int? WorkLocationID { get; set; }
        public WorkLocation? WorkLocation { get; set; }
    }
}