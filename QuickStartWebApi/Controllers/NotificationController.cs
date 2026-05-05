using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QuickStartWebApi.Context;
using QuickStartWebApi.DTOs;
using QuickStartWebApi.Entity;

namespace QuickStartWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotificationController : ControllerBase
    {
        private readonly QuickStartContext _quickStartContext;

        public NotificationController(QuickStartContext quickStartContext)
        {
            _quickStartContext = quickStartContext;
        }

        [HttpGet]
        public IActionResult GetNotificationList()
        {
            var values = _quickStartContext.Notifications.ToList();
            return Ok(values);
        }

        [HttpGet("GetNotificationListWithNotificationType")]
        public IActionResult GetNotificationListWithNotificationType()
        {
            var values = _quickStartContext.Notifications
                .Select(x => new ResultNotificationWithNotificationTypeDto
                {
                    NotificationId = x.NotificationId,
                    Title = x.Title,
                    Content = x.Content,
                    IsRead = x.IsRead,
                    Name = x.Name,
                }).OrderByDescending(x => x.NotificationId).ToList();
            return Ok(values);
        }
        [HttpGet("ChangeNotificationStatus/{id}")]
        public IActionResult ChangeNotificationStatus(int id)
        {
            var value = _quickStartContext.Notifications.Find(id);
            if (value == null) return NotFound();

            value.IsRead = !value.IsRead;
            _quickStartContext.SaveChanges();
            return Ok();
        }
        [HttpPost]
        public IActionResult CreateNotification(Notification notification)
        {
            _quickStartContext.Notifications.Add(notification);
            _quickStartContext.SaveChanges();
            return Ok("Bildirim başarıyla eklendi.");
        }
        [HttpPut]
        public IActionResult UpdateNotification(Notification notification)
        {
            var existingValue = _quickStartContext.Notifications
        .AsNoTracking()
        .FirstOrDefault(x => x.NotificationId == notification.NotificationId);

            if (existingValue == null) return NotFound("Güncellenecek bildirim bulunamadı.");

            _quickStartContext.Notifications.Update(notification);
            _quickStartContext.SaveChanges();
            return Ok("Güncelleme başarılı.");
        }

        [HttpGet("{id}")]
        public IActionResult GetNotification(int id)
        {
            var value = _quickStartContext.Notifications.Find(id);
            return Ok(value);
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteNotification(int id)
        {
            var value = _quickStartContext.Notifications.Find(id);
            if (value == null) return NotFound();

            _quickStartContext.Notifications.Remove(value);
            _quickStartContext.SaveChanges();
            return Ok("Bildirim başarıyla silindi.");
        }
    }
}

