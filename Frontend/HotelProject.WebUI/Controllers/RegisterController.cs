using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using HotelProject.EntityLayer.Concrete;
using HotelProject.WebUI.Dtos.RegisterDto;

namespace HotelProject.WebUI.Controllers
{
    public class RegisterController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public RegisterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(UserCreateDto userCreateDto)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            var appUser = new AppUser()
            {
                Name = userCreateDto.Name,
                Surname = userCreateDto.Surname,
                Email = userCreateDto.Mail,
                UserName = userCreateDto.Username
            };

            var result = await _userManager.CreateAsync(appUser,userCreateDto.Password!);
            if (result.Succeeded)
            {
                return RedirectToAction("Index","Login");
            }
            return View();
        }

    }
}