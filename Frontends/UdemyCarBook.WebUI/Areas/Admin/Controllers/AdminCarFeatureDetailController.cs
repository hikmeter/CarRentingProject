using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using UdemyCarBook.Dto.CarFeatureDtos;
using UdemyCarBook.Dto.FeatureDtos;

namespace UdemyCarBook.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]/{id?}")]
    public class AdminCarFeatureDetailController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public AdminCarFeatureDetailController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        [HttpGet]
        public async Task<IActionResult> Index(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"https://localhost:7228/api/CarFeatures?id={id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultCarFeatureByCarIdDto>>(jsonData);
                return View(values);
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(List<ResultCarFeatureByCarIdDto> dto)
        {
            foreach (var item in dto)
            {
                if (item.available)
                {
                    var client = _httpClientFactory.CreateClient();
                    await client.GetAsync($"https://localhost:7228/api/CarFeatures/CarFeatureChangeAvailableToTrue?id={item.carFeatureID}");
                }
                else
                {
                    var client = _httpClientFactory.CreateClient();
                    await client.GetAsync($"https://localhost:7228/api/CarFeatures/CarFeatureChangeAvailableToFalse?id={item.carFeatureID}");
                }
            }
            return RedirectToAction("Index", "AdminCar");
        }
        [HttpGet]
        public async Task<IActionResult> CreateFeatureByCar()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"https://localhost:7228/api/Features");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultFeatureDto>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
