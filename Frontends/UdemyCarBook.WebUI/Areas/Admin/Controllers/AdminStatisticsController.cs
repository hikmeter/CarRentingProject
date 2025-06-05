using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using UdemyCarBook.Dto.StatisticsDtos;

namespace UdemyCarBook.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]/{id?}")]
    public class AdminStatisticsController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public AdminStatisticsController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IActionResult> Index()
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
            #region 3rdStatistics
            int v3 = random.Next(0, 101);
            var responseMessage3 = await client.GetAsync("https://localhost:7228/api/Statistics/GetAuthorCount");
            if (responseMessage3.IsSuccessStatusCode)
            {
                var jsonData3 = await responseMessage3.Content.ReadAsStringAsync();
                var values3 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData3);
                ViewBag.authorCount = values3.result.authorCount;
                ViewBag.v3 = v3;
            }
            #endregion
            #region 4thStatistics
            int v4 = random.Next(0, 101);
            var responseMessage4 = await client.GetAsync("https://localhost:7228/api/Statistics/GetBlogCount");
            if (responseMessage4.IsSuccessStatusCode)
            {
                var jsonData4 = await responseMessage4.Content.ReadAsStringAsync();
                var values4 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData4);
                ViewBag.blogCount = values4.result.blogCount;
                ViewBag.v4 = v4;
            }
            #endregion
            #region 5thStatistics
            int v5 = random.Next(0, 101);
            var responseMessage5 = await client.GetAsync("https://localhost:7228/api/Statistics/GetBrandCount");
            if (responseMessage4.IsSuccessStatusCode)
            {
                var jsonData5 = await responseMessage5.Content.ReadAsStringAsync();
                var values5 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData5);
                ViewBag.brandCount = values5.result.brandCount;
                ViewBag.v5 = v5;
            }
            #endregion
            #region 6thStatistics
            int v6 = random.Next(0, 101);
            var responseMessage6 = await client.GetAsync("https://localhost:7228/api/Statistics/GetAverageDailyRentPrice");
            if (responseMessage6.IsSuccessStatusCode)
            {
                var jsonData6 = await responseMessage6.Content.ReadAsStringAsync();
                var values6 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData6);
                ViewBag.averageDailyRentPrice = values6.result.averageDailyRentPrice;
                ViewBag.v6 = v6;
            }
            #endregion
            #region 7thStatistics
            int v7 = random.Next(0, 101);
            var responseMessage7 = await client.GetAsync("https://localhost:7228/api/Statistics/GetAverageWeeklyRentPrice");
            if (responseMessage7.IsSuccessStatusCode)
            {
                var jsonData7 = await responseMessage7.Content.ReadAsStringAsync();
                var values7 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData7);
                ViewBag.averageWeeklyRentPrice = values7.result.averageWeeklyRentPrice;
                ViewBag.v7 = v7;
            }
            #endregion
            #region 8thStatistics
            int v8 = random.Next(0, 101);
            var responseMessage8 = await client.GetAsync("https://localhost:7228/api/Statistics/GetAverageMonthlyRentPrice");
            if (responseMessage8.IsSuccessStatusCode)
            {
                var jsonData8 = await responseMessage8.Content.ReadAsStringAsync();
                var values8 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData8);
                ViewBag.averageMonthlyRentPrice = values8.result.averageMonthlyRentPrice;
                ViewBag.v8 = v8;
            }
            #endregion
            #region 9thStatistics
            int v9 = random.Next(0, 101);
            var responseMessage9 = await client.GetAsync("https://localhost:7228/api/Statistics/GetAutomaticTransmissionCarCount");
            if (responseMessage9.IsSuccessStatusCode)
            {
                var jsonData9 = await responseMessage9.Content.ReadAsStringAsync();
                var values9 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData9);
                ViewBag.automaticTransmissionCarCount = values9.result.automaticTransmissionCarCount;
                ViewBag.v9 = v9;
            }
            #endregion
            #region 10thStatistics
            int v10 = random.Next(0, 101);
            var responseMessage10 = await client.GetAsync("https://localhost:7228/api/Statistics/GetBrandWithMostCars");
            if (responseMessage10.IsSuccessStatusCode)
            {
                var jsonData10 = await responseMessage10.Content.ReadAsStringAsync();
                var values10 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData10);
                ViewBag.brandWithMostCars = values10.result.brandWithMostCars;
                ViewBag.v10 = v10;
            }
            #endregion
            #region 11thStatistics
            int v11 = random.Next(0, 101);
            var responseMessage11 = await client.GetAsync("https://localhost:7228/api/Statistics/GetBlogWithMostComments");
            if (responseMessage11.IsSuccessStatusCode)
            {
                var jsonData11 = await responseMessage11.Content.ReadAsStringAsync();
                var values11 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData11);
                ViewBag.blogWithMostComments = values11.result.blogWithMostComments;
                ViewBag.v11 = v11;
            }
            #endregion
            #region 12thStatistics
            int v12 = random.Next(0, 101);
            var responseMessage12 = await client.GetAsync("https://localhost:7228/api/Statistics/GetCarCountWithLessThan10000Km");
            if (responseMessage12.IsSuccessStatusCode)
            {
                var jsonData12 = await responseMessage12.Content.ReadAsStringAsync();
                var values12 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData12);
                ViewBag.carCountWithLessThan10000Km = values12.result.carCountWithLessThan10000Km;
                ViewBag.v12 = v12;
            }
            #endregion
            #region 13thStatistics
            int v13 = random.Next(0, 101);
            var responseMessage13 = await client.GetAsync("https://localhost:7228/api/Statistics/GetCarCountWithGasolineOrDiesel");
            if (responseMessage13.IsSuccessStatusCode)
            {
                var jsonData13 = await responseMessage13.Content.ReadAsStringAsync();
                var values13 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData13);
                ViewBag.carCountWithGasolineOrDiesel = values13.result.carCountWithGasolineOrDiesel;
                ViewBag.v13 = v13;
            }
            #endregion
            #region 14thStatistics
            int v14 = random.Next(0, 101);
            var responseMessage14 = await client.GetAsync("https://localhost:7228/api/Statistics/GetCarCountElectricFuel");
            if (responseMessage14.IsSuccessStatusCode)
            {
                var jsonData14 = await responseMessage14.Content.ReadAsStringAsync();
                var values14 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData14);
                ViewBag.carCountElectricFuel = values14.result.carCountElectricFuel;
                ViewBag.v14 = v14;
            }
            #endregion
            #region 15thStatistics
            int v15 = random.Next(0, 101);
            var responseMessage15 = await client.GetAsync("https://localhost:7228/api/Statistics/GetMostExpensiveCarByDailyRent");
            if (responseMessage15.IsSuccessStatusCode)
            {
                var jsonData15 = await responseMessage15.Content.ReadAsStringAsync();
                var values15 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData15);
                ViewBag.mostExpensiveCarByDailyRent = values15.result.mostExpensiveCarByDailyRent;
                ViewBag.v15 = v15;
            }
            #endregion
            #region 16thStatistics
            int v16 = random.Next(0, 101);
            var responseMessage16 = await client.GetAsync("https://localhost:7228/api/Statistics/GetCheapestCarByDailyRent");
            if (responseMessage16.IsSuccessStatusCode)
            {
                var jsonData16 = await responseMessage16.Content.ReadAsStringAsync();
                var values16 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData16);
                ViewBag.cheapestCarByDailyRent = values16.result.cheapestCarByDailyRent;
                ViewBag.v16 = v16;
            }
            #endregion
            return View();
        }
    }
}
