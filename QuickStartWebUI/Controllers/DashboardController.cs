using Microsoft.AspNetCore.Mvc;

namespace QuickStartWebUI.Controllers
{
    public class DashboardController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public DashboardController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();

            var responseMessage = await client.GetAsync("https://localhost:7146/api/Testimonial/TestimonialCount");
            var JsonData = await responseMessage.Content.ReadAsStringAsync();
            ViewBag.TestimonialCount = JsonData;

            var responseMessage1 = await client.GetAsync("https://localhost:7146/api/Service/ServiceCount");
            var JsonData1 = await responseMessage1.Content.ReadAsStringAsync();
            ViewBag.ServiceCount = JsonData1;

            var responseMessage2 = await client.GetAsync("https://localhost:7146/api/Gallery/GalleryCount");
            var JsonData2 = await responseMessage2.Content.ReadAsStringAsync();
            ViewBag.GalleryCount = JsonData2;

            var responseMessage3 = await client.GetAsync("https://localhost:7146/api/Feature/FeatureCount");
            var JsonData3 = await responseMessage3.Content.ReadAsStringAsync();
            ViewBag.FeatureCount = JsonData3;

            var responseMessage4 = await client.GetAsync("https://localhost:7146/api/Subscribe/SubscribeCount");
            var JsonData4 = await responseMessage4.Content.ReadAsStringAsync();
            ViewBag.SubscribeCount = JsonData4;

            var responseMessage5 = await client.GetAsync("https://localhost:7146/api/Team/TeamCount");
            var JsonData5 = await responseMessage5.Content.ReadAsStringAsync();
            ViewBag.TeamCount = JsonData5;

            return View();
        }
    }
}

