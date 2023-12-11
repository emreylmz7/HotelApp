using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Concrete;
using HotelProject.EntityLayer.Concrete;
using HotelProjectAPI.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HotelProjectAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AppUserController : ControllerBase
    {
        private readonly IAppUserService _appUserService;
        public AppUserController(IAppUserService appUserService)
        {
            _appUserService = appUserService;
        }

        [HttpGet("UserListWithWorkLocation")]
        public IActionResult UserListWithWorkLocation()
        {
            Context context = new Context();
            var values = context.Users
                                .Include(x => x.WorkLocation)
                                .Select(y => new UserWithWorkLocationDto
                                {
                                    Name = y.Name,
                                    Surname = y.Surname,
                                    Gender = y.Gender,
                                    Country = y.Country,
                                    City = y.City,
                                    ImageUrl = y.ImageUrl,
                                    WorkDepartmant = y.WorkDepartmant,
                                    WorkLocationID = y.WorkLocation!.WorkLocationID, 
                                    WorkLocationName = y.WorkLocation.Name
                                })
                                .ToList();

            // var values = _appUserService.TUserListWithWorkLocation();
            return Ok(values);
        }


        // [HttpGet]
        // public IActionResult AppUserList()
        // {
        //     var values = _appUserService.TGetList();
        //     return Ok(values);
        // }

        // [HttpPost]
        // public IActionResult AddAppUser(AppUser appUser)
        // {
        //     _appUserService.TInsert(appUser);
        //     return Ok();
        // }

        // [HttpDelete("{id}")]
        // public IActionResult DeleteAppUser(int id)
        // {
        //     var value = _appUserService.TGetById(id);
        //     _appUserService.TDelete(value);
        //     return Ok();
        // }

        // [HttpPut]
        // public IActionResult UpdateAppUser(AppUser appUser)
        // {
        //     _appUserService.TUpdate(appUser);
        //     return Ok();
        // }

        // [HttpGet("{id}")]
        // public IActionResult GetAppUser(int id)
        // {
        //     var value = _appUserService.TGetById(id);
        //     return Ok(value);
        // }
    }
}