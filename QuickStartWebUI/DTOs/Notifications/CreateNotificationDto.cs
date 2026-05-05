namespace QuickStartWebUI.DTOs.Notifications
{
    public class CreateNotificationDto
    {
        public string? Title { get; set; }
        public string? Content { get; set; }
        public bool IsRead { get; set; }
        public string? Name { get; set; }
    }
}
