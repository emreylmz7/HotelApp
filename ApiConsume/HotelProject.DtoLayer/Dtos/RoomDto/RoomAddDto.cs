using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HotelProject.DtoLayer.Dtos.RoomDto
{
    public class RoomAddDto
    {
        [Required(ErrorMessage = "Please Enter Room Number")]
        public string? RoomNumber { get; set; }
        public string? RoomCoverImage { get; set; }

        [Required(ErrorMessage = "Please Enter Price Information")]
        public int Price { get; set; }

        [Required(ErrorMessage = "Please Enter Room Title")]
        public string? Title { get; set; }

        [Required(ErrorMessage = "Please enter the number of Bed")]
        public string? BedCount { get; set; }

        [Required(ErrorMessage = "Please enter the number of bathrooms")]
        public string? BathCount { get; set; }
        public string? Wifi { get; set; }
        public string? Description { get; set; }
    }
}