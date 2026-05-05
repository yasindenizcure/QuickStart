namespace QuickStartWebApi.Entity
{
    public class Notification
    {
        public int NotificationId { get; set; }
        public string? Title { get; set; }
        public string? Content { get; set; }
        public bool IsRead { get; set; }

        public string? Name { get; set; }
        public int NotificationTypeId { get; set; }

    }
}
