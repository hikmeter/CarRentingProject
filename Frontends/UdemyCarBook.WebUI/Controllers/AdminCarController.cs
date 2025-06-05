using Humanizer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using UdemyCarBook.Dto.BrandDtos;
using UdemyCarBook.Dto.CarDtos;

namespace UdemyCarBook.WebUI.Controllers
{
    public class AdminCarController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public AdminCarController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7228/api/Cars/GetCarWithBrand");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultCarWithBrandDto>>(jsonData);
                return View(values);
            }
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> CreateCar()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7228/api/Brands");
            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<ResultBrandDto>>(jsonData);
            List<SelectListItem> brandValues = (from x in values
                                                select new SelectListItem
                                                {
                                                    Text = x.name,
                                                    Value = x.brandID.ToString()
                                                }).ToList();
            ViewBag.brandValues = brandValues;
            ViewBag.FuelTypes = new List<SelectListItem>
    {
        new SelectListItem { Value = "Benzin", Text = "Benzin" },
        new SelectListItem { Value = "Dizel", Text = "Dizel" },
        new SelectListItem { Value = "Elektrik", Text = "Elektrik" },
        new SelectListItem { Value = "Hibrit", Text = "Hibrit" }
    };

            ViewBag.TransmissionTypes = new List<SelectListItem>
    {
        new SelectListItem { Value = "Manuel", Text = "Manuel" },
        new SelectListItem { Value = "Otomatik", Text = "Otomatik" },
        new SelectListItem { Value = "Yarı Otomatik", Text = "Yarı Otomatik" }
    };
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateCar(CreateCarDto dto)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(dto);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync("https://localhost:7228/api/Cars", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
        public async Task<IActionResult> RemoveCar(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.DeleteAsync($"https://localhost:7228/api/Cars/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> UpdateCar(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessageBrand = await client.GetAsync("https://localhost:7228/api/Brands");
            var jsonDataBrand = await responseMessageBrand.Content.ReadAsStringAsync();
            var valuesBrand = JsonConvert.DeserializeObject<List<ResultBrandDto>>(jsonDataBrand);
            List<SelectListItem> brandValues = (from x in valuesBrand
                                                select new SelectListItem
                                                {
                                                    Text = x.name,
                                                    Value = x.brandID.ToString()
                                                }).ToList();
            ViewBag.brandValues = brandValues;
            ViewBag.FuelTypes = new List<SelectListItem>
    {
        new SelectListItem { Value = "Benzin", Text = "Benzin" },
        new SelectListItem { Value = "Dizel", Text = "Dizel" },
        new SelectListItem { Value = "Elektrik", Text = "Elektrik" },
        new SelectListItem { Value = "Hibrit", Text = "Hibrit" }
    };

            ViewBag.TransmissionTypes = new List<SelectListItem>
    {
        new SelectListItem { Value = "Manuel", Text = "Manuel" },
        new SelectListItem { Value = "Otomatik", Text = "Otomatik" },
        new SelectListItem { Value = "Yarı Otomatik", Text = "Yarı Otomatik" }
    };
            var responseMessage = await client.GetAsync($"https://localhost:7228/api/Cars/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<UpdateCarDto>(jsonData);
                return View(values);
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> UpdateCar(UpdateCarDto dto)
        {

            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(dto);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PutAsync("https://localhost:7228/api/Cars/", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
