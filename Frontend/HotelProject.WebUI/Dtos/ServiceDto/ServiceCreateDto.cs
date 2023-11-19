using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HotelProject.WebUI.Dtos.ServiceDto
{
    public class ServiceCreateDto
    {
        [Required(ErrorMessage = "Please Enter Icon Link")]
        public string? ServiceIcon { get; set; }

        [StringLength(100,ErrorMessage = "Service Title must be a Max 100 Character")]
        [Required(ErrorMessage = "Please Enter Service Title")]
        public string? Title { get; set; }

        [StringLength(500,ErrorMessage = "Service Description must be a Max 500 Character")]
        [Required(ErrorMessage = "Please Enter Service Description")]
        public string? Description { get; set; }
    }
}