using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using UdemyCarBook.Dto.StatisticsDtos;

namespace UdemyCarBook.WebUI.ViewComponents.DashboardViewComponents
{
    public class _AdminDashboardStatisticsComponentPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public _AdminDashboardStatisticsComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            #region 1stStatistics
            Random random = new Random();
            int v1 = random.Next(0, 101);
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7228/api/Statistics/GetCarCount");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData);
                ViewBag.carCount = values.result.carCount;
                ViewBag.v1 = v1;
            }
            #endregion
            #region 2ndStatistics
            int v2 = random.Next(0, 101);
            var responseMessage2 = await client.GetAsync("https://localhost:7228/api/Statistics/GetLocationCount");
            if (responseMessage2.IsSuccessStatusCode)
            {
                var jsonData2 = await responseMessage2.Content.ReadAsStringAsync();
                var values2 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData2);
                ViewBag.locationCount = values2.result.locationCount;
                ViewBag.v2 = v2;
            }
            #endregion
            #region 3thStatistics
            int v3 = random.Next(0, 101);
            var responseMessage3 = await client.GetAsync("https://localhost:7228/api/Statistics/GetBrandCount");
            if (responseMessage3.IsSuccessStatusCode)
            {
                var jsonData3 = await responseMessage3.Content.ReadAsStringAsync();
                var values3 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData3);
                ViewBag.brandCount = values3.result.brandCount;
                ViewBag.v3 = v3;
            }
            #endregion
            #region 4thStatistics
            int v4 = random.Next(0, 101);
            var responseMessage4 = await client.GetAsync("https://localhost:7228/api/Statistics/GetAverageDailyRentPrice");
            if (responseMessage4.IsSuccessStatusCode)
            {
                var jsonData4 = await responseMessage4.Content.ReadAsStringAsync();
                var values4 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData4);
                ViewBag.averageDailyRentPrice = values4.result.averageDailyRentPrice;
                ViewBag.v4 = v4;
            }
            #endregion
            return View();
        }
    }
}
