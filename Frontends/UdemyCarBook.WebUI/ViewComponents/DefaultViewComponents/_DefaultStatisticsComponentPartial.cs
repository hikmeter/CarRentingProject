using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using UdemyCarBook.Dto.StatisticsDtos;

namespace UdemyCarBook.WebUI.ViewComponents.DefaultViewComponents
{
    public class _DefaultStatisticsComponentPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public _DefaultStatisticsComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            #region 1stStatistics
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7228/api/Statistics/GetCarCount");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData);
                ViewBag.carCount = values.result.carCount;
            }
            #endregion
            #region 2ndStatistics
            int year = DateTime.Now.Year;
            int statistic = year - 2025;
            if(statistic == 0)
            {
                statistic = 1;
            }
            ViewBag.statistic = statistic;
            #endregion
            #region 3rdStatistics
            var responseMessage4 = await client.GetAsync("https://localhost:7228/api/Statistics/GetBlogCount");
            if (responseMessage4.IsSuccessStatusCode)
            {
                var jsonData4 = await responseMessage4.Content.ReadAsStringAsync();
                var values4 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData4);
                ViewBag.blogCount = values4.result.blogCount;
            }
            #endregion
            #region 4thStatistics
            var responseMessage2 = await client.GetAsync("https://localhost:7228/api/Statistics/GetLocationCount");
            if (responseMessage2.IsSuccessStatusCode)
            {
                var jsonData2 = await responseMessage2.Content.ReadAsStringAsync();
                var values2 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData2);
                ViewBag.locationCount = values2.result.locationCount;
            }
            #endregion
            return View();
        }
    }
}
