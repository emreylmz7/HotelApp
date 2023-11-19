using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebUI.ViewComponents.Default
{
    public class _SpinnerPartial: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
        
    }
}