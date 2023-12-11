using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelProject.WebUI.Dtos.FollowersDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace HotelProject.WebUI.ViewComponents.Dashboard
{
    public class _DashboardSubscribePartial:ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            //INSTAGRAM API

            ResultInstagramFollowersDto resultInstagramFollowersDto = new ResultInstagramFollowersDto();
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://instagram-profile1.p.rapidapi.com/getprofile/emree.ylmz7"),
                Headers =
                {
                    { "X-RapidAPI-Key", "ee88acbeb9msh926c211b1dd1d3cp1147bdjsn3c6c0362a6d2" },
                    { "X-RapidAPI-Host", "instagram-profile1.p.rapidapi.com" },
                },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                resultInstagramFollowersDto = JsonConvert.DeserializeObject<ResultInstagramFollowersDto>(body)!;
                ViewBag.InstagramFollowers = resultInstagramFollowersDto.followers;
                ViewBag.InstagramFollowing = resultInstagramFollowersDto.following;
            }

            //TWITTER API

            ResultTwitterFollowersDto resultTwitterFollowersDto = new ResultTwitterFollowersDto();
            var client2 = new HttpClient();
            var request2 = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://twitter154.p.rapidapi.com/user/details?username=vemreylmz"),
                Headers =
                {
                    { "X-RapidAPI-Key", "ee88acbeb9msh926c211b1dd1d3cp1147bdjsn3c6c0362a6d2" },
                    { "X-RapidAPI-Host", "twitter154.p.rapidapi.com" },
                },
            };
            using (var response2 = await client2.SendAsync(request2))
            {
                response2.EnsureSuccessStatusCode();
                var body = await response2.Content.ReadAsStringAsync();
                resultTwitterFollowersDto = JsonConvert.DeserializeObject<ResultTwitterFollowersDto>(body)!;
                ViewBag.TwitterFollowers = resultTwitterFollowersDto.follower_count;
                ViewBag.TwitterFollowing = resultTwitterFollowersDto.following_count;
            }

            //LINKEDIN API

            ResultLinkedinFollowersDto resultLinkedinFollowersDto = new ResultLinkedinFollowersDto();
            var client3 = new HttpClient();
            var request3 = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://fresh-linkedin-profile-data.p.rapidapi.com/get-linkedin-profile?linkedin_url=https%3A%2F%2Fwww.linkedin.com%2Fin%2Fveysel-emre-yilmaz%2F&include_skills=false"),
                Headers =
                {
                    { "X-RapidAPI-Key", "ee88acbeb9msh926c211b1dd1d3cp1147bdjsn3c6c0362a6d2" },
                    { "X-RapidAPI-Host", "fresh-linkedin-profile-data.p.rapidapi.com" },
                },
            };
            using (var response3 = await client3.SendAsync(request3))
            {
                response3.EnsureSuccessStatusCode();
                var body = await response3.Content.ReadAsStringAsync();
                resultLinkedinFollowersDto = JsonConvert.DeserializeObject<ResultLinkedinFollowersDto>(body)!;
                ViewBag.LinkedinFollowers = resultLinkedinFollowersDto.data!.follower_count;
                ViewBag.LinkedinConnections = resultLinkedinFollowersDto.data!.connections_count;
            }

            return View();
        }
    }
}    