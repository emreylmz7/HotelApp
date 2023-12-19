using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using HotelProject.EntityLayer.Concrete;
using HotelProject.WebUI.Models.Role;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace HotelProject.WebUI.Controllers
{
    public class AdminRolesController : Controller
    {
        private readonly RoleManager<AppRole> _roleManager;
        public AdminRolesController(RoleManager<AppRole> roleManager)
        {
            _roleManager = roleManager;
        }
        public IActionResult Index()
        {
            var values = _roleManager.Roles.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddRole()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddRole(AddRoleViewModel model)
        {
            AppRole appRole = new AppRole()
            {
                Name = model.RoleName
            };
            var result = await _roleManager.CreateAsync(appRole);
            if (result.Succeeded)
            {
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public IActionResult UpdateRole(int Id)
        {
            var value = _roleManager.Roles.FirstOrDefault(x => x.Id == Id)!;
            UpdateRoleViewModel updateRoleViewModel = new UpdateRoleViewModel()
            {
                RoleName = value.Name!,
                RoleId = value.Id
            };
            return View(updateRoleViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateRole(UpdateRoleViewModel model)
        {
            var value = _roleManager.Roles.FirstOrDefault(x=> x.Id == model.RoleId);
            value!.Name = model.RoleName;
            await _roleManager.UpdateAsync(value);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> DeleteRole(int Id)
        {
            var value = _roleManager.Roles.FirstOrDefault(x => x.Id == Id);
            await _roleManager.DeleteAsync(value!);
            return RedirectToAction("Index");
        }

    }
}