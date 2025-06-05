using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using UdemyCarBook.Dto.CarPricingDtos;

namespace UdemyCarBook.WebUI.ViewComponents.DashboardViewComponents
{
    public class _AdminDashboardCarPricingListComponentPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public _AdminDashboardCarPricingListComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7228/api/CarPricings/GetCarPricingsWithTimePeriods");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultCarPricingsWithTimePeriodsDto>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
