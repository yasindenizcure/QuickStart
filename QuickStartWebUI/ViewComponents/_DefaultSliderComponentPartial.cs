using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using QuickStartWebUI.DTOs.Services;
using QuickStartWebUI.DTOs.Sliders;

namespace QuickStartWebUI.ViewComponents
{
    public class _DefaultSliderComponentPartial: ViewComponent
    {
        private IHttpClientFactory _httpClientFactory;

        public _DefaultSliderComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var response = await client.GetAsync("https://localhost:7146/api/Slider");
            if (response.IsSuccessStatusCode)
            {
                var jsonData = await response.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultSliderDto>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
