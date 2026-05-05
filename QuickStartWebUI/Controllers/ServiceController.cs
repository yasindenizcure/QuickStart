using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using QuickStartWebUI.DTOs.Services;
using System.Text;
using System.Text.Json.Serialization;

namespace QuickStartWebUI.Controllers
{
    public class ServiceController : Controller
    {
        //API - Farklı programların birbiriyle konuşmasını sağlar.
        //HTTP - İnternetteki cihazların birbiriyle konuşmasını sağlayan protokol.
        //HttpClient - Apiye http isteklerini göndermek için kullanıyoruz.
        private readonly IHttpClientFactory _httpClientFactory;

        public ServiceController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task< IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var response = await client.GetAsync("https://localhost:7146/api/Service");
            if (response.IsSuccessStatusCode) 
            {
                var jsonData = await response.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultServiceDto>>(jsonData);
                return View(values);
            } 
            return View();
        }
        [HttpGet]
        public IActionResult CreateService()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateService(CreateServiceDto createServiceDto)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(createServiceDto); //string'ten JSON'a çevirmek için.
            var content = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var response = await client.PostAsync("https://localhost:7146/api/Service", content);
            if (response.IsSuccessStatusCode) 
            {
                return RedirectToAction("Index");
            }
            return View(createServiceDto);
        }
        [HttpGet]
        public async Task<IActionResult> UpdateService(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var response = await client.GetAsync("https://localhost:7146/api/Service/" + id);
            var JsonData = await response.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<UpdateServiceDto>(JsonData); 
            return View(values);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateService(UpdateServiceDto updateServiceDto)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(updateServiceDto); //TEXT'ten JSON'a.
            var content = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var response = await client.PutAsync("https://localhost:7146/api/Service/", content);
            if (response.IsSuccessStatusCode) 
            { 
                return RedirectToAction("Index"); 
            }
            return View(updateServiceDto);
        }
        [HttpGet]
        public async Task<IActionResult> DeleteService(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var response = await client.DeleteAsync($"https://localhost:7146/api/Service/{id}");
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return BadRequest("Silme başarısız");
        }
    }
}
