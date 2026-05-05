using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using QuickStartWebUI.DTOs.Notifications;
using System.Net.Http;

namespace QuickStartWebUI.ViewComponents
{
    public class _AdminLayoutSidebarComponentPartial: ViewComponent
    {
        private IHttpClientFactory _httpClientFactory;

        public _AdminLayoutSidebarComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7146/api/Notification/NotificationListByStatus");

            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultNotificationWithNotificationsTypeDto>>(jsonData);
                return View(values);
            }

            // EĞER VERİ GELMEZSE: Null dönmek yerine boş bir liste dön ki hata vermesin.
            return View(new List<ResultNotificationWithNotificationsTypeDto>());
        }
    }
}
