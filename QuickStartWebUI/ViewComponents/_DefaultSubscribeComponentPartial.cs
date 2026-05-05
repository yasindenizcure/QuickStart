using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using QuickStartWebUI.DTOs.Abouts;
using QuickStartWebUI.DTOs.Subscribes;

namespace QuickStartWebUI.ViewComponents
{
    public class _DefaultSubscribeComponentPartial: ViewComponent
    {
        private IHttpClientFactory _httpClientFactory;

        public _DefaultSubscribeComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var response = await client.GetAsync("https://localhost:7146/api/Subscribe");
            if (response.IsSuccessStatusCode)
            {
                var jsonData = await response.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultSubscribeDto>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
