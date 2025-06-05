using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using UdemyCarBook.Dto.AuthorDtos;

namespace UdemyCarBook.WebUI.ViewComponents.BlogViewComponents
{
    public class _BlogDetailAboutAuthorComponentPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public _BlogDetailAboutAuthorComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            ViewBag.blogid = id;
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"https://localhost:7228/api/Blogs/GetAuthorByBlogId?id=" + id);
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultGetAuthorByBlogIdDto>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
