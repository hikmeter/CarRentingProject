using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;
using UdemyCarBook.Dto.CarDtos;

namespace UdemyCarBook.WebUI.ViewComponents.CarDetailViewComponents
{
    public class _CarDetailMainCarFeaturesComponentPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public _CarDetailMainCarFeaturesComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            ViewBag.carid = id;
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"https://localhost:7228/api/Cars/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ResultCarWithBrandDto>(jsonData);
                return View(values);
            }
            return View();
        }
    }
    }
