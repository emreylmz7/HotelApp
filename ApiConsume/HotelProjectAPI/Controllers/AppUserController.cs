using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

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

        [HttpGet]
        public IActionResult UserListWithWorkLocation()
        {
            var values = _appUserService.TUserListWithWorkLocation();
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