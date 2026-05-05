using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using QuickStartWebUI.DTOs.Testimonials;

namespace QuickStartWebUI.ViewComponents
{
    public class _DefaultTestimonialComponentPartial: ViewComponent
    {
        private IHttpClientFactory _httpClientFactory;

        public _DefaultTestimonialComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync() 
        {
            var client = _httpClientFactory.CreateClient();
            var response = await client.GetAsync("https://localhost:7146/api/Testimonial");
            if (response.IsSuccessStatusCode) 
            {
                var jsonData = await response.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultTestimonialDto>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
