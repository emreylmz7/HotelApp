using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HotelProject.WebUI.Dtos.RegisterDto
{
    public class UserCreateDto
    {
        [Required(ErrorMessage = "Name is Required")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Surname is Required")]
        public string? Surname { get; set; }

        [Required(ErrorMessage = "Username is Required")]
        public string? Username { get; set; }

        [Required(ErrorMessage = "Mail is Required")]
        public string? Mail { get; set; }

        [Required(ErrorMessage = "Password is Required")]
        public string? Password { get; set; }

        [Required(ErrorMessage = "Confirm Password is Required")]
        [Compare("Password",ErrorMessage = "Passwords do not match")]
        public string? ConfirmPassword { get; set; }
    }
}