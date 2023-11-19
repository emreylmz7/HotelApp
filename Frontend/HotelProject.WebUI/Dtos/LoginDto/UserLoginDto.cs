using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HotelProject.WebUI.Dtos.LoginDto
{
    public class UserLoginDto
    {
        [Required(ErrorMessage = "Please Enter Username")]
        public string Username { get; set; } = null!;

        [Required(ErrorMessage = "Please Enter Password")]
        public string Password { get; set; } = null!;
        
    }
}