using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebUI.ViewComponents.Dashboard
{
    public class _DashboardWidgetPartial:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public _DashboardWidgetPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:5224/api/Staff/GetStaffCount");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                // var values = JsonConvert.DeserializeObject<List<ResultAboutDto>>(jsonData);
                ViewBag.staffCount = jsonData;
            }

            var client2 = _httpClientFactory.CreateClient();
            var responseMessage2 = await client2.GetAsync("http://localhost:5224/api/Booking/BookingCount");
            if (responseMessage2.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage2.Content.ReadAsStringAsync();
                // var values = JsonConvert.DeserializeObject<List<ResultAboutDto>>(jsonData);
                ViewBag.bookingCount = jsonData;
            }

            var client3 = _httpClientFactory.CreateClient();
            var responseMessage3 = await client3.GetAsync("http://localhost:5224/api/Guest/GuestCount");
            if (responseMessage3.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage3.Content.ReadAsStringAsync();
                // var values = JsonConvert.DeserializeObject<List<ResultAboutDto>>(jsonData);
                ViewBag.guestCount = jsonData;
            }

            var client4 = _httpClientFactory.CreateClient();
            var responseMessage4 = await client4.GetAsync("http://localhost:5224/api/Room/RoomCount");
            if (responseMessage4.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage4.Content.ReadAsStringAsync();
                // var values = JsonConvert.DeserializeObject<List<ResultAboutDto>>(jsonData);
                ViewBag.roomCount = jsonData;
            }

            return View();
        }
    }
}