using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace HotelProject.WebUI.Controllers
{
    [AllowAnonymous]
    public class RoomController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}