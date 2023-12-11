using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelProject.WebUI.Dtos.FollowersDto
{
    public class ResultTwitterFollowersDto
    {
        public int following_count { get; set; }
        public int follower_count { get; set; }
    }
}