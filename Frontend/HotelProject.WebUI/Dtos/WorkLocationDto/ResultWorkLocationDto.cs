using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelProject.WebUI.Dtos.WorkLocationDto
{
    public class ResultWorkLocationDto
    {
        public int WorkLocationID { get; set; }
        public string? Name { get; set; }
        public string? City { get; set; }

    }
}