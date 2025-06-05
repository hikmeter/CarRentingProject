using Humanizer;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;
using UdemyCarBook.Dto.BlogDtos;
using UdemyCarBook.Dto.CommentDtos;

namespace UdemyCarBook.WebUI.Controllers
{
    public class BlogController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public BlogController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IActionResult> Index()
        {
            ViewBag.v1 = "Bloglar";
            ViewBag.v2 = "Bloglarımız";
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7228/api/Blogs/GetAllBlogsWithAuthorsList");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultAllBlogsWithAuthorsDto>>(jsonData);
                return View(values);
            }
            return View();
        }
        public async Task<IActionResult> BlogDetail(int id)
        {
            ViewBag.v1 = "Bloglar";
            ViewBag.v2 = "Blogumuzu Oku";
            ViewBag.blogid = id;
            return View();
        }
        [HttpGet]
        public PartialViewResult AddComment(int id)
        {
            ViewBag.blogid = id;
            return PartialView();
        }
        [HttpPost]
        public async Task<IActionResult> AddComment(CreateCommentDto dto)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(dto);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync("https://localhost:7228/api/Comments/AddComment", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
