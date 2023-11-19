using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HotelProject.DtoLayer.Dtos.RoomDto
{
    public class RoomUpdateDto
    {
        public int RoomID { get; set; }

        [Required(ErrorMessage = "Please Enter Room Number")]
        public string? RoomNumber { get; set; }

        [Required(ErrorMessage = "Please Enter Room Image")]
        public string? RoomCoverImage { get; set; }

        [Required(ErrorMessage = "Please Enter Price Information")] 
        public int Price { get; set; }

        [StringLength(100,ErrorMessage = "Please Enter Max. 100 Character")]
        [Required(ErrorMessage = "Please Enter Room Title")]
        public string? Title { get; set; }

        [Required(ErrorMessage = "Please enter the number of Bed")]
        public string? BedCount { get; set; }

        [Required(ErrorMessage = "Please enter the number of bathrooms")]
        public string? BathCount { get; set; }
        public string? Wifi { get; set; }

        [Required(ErrorMessage = "Please enter the Description")]
        public string? Description { get; set; }
        
    }
}