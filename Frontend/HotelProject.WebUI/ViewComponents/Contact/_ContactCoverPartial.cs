using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebUI.ViewComponents.Contact
{
    public class _ContactCoverPartial:ViewComponent
    {
         public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}