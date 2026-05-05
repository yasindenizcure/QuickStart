namespace QuickStartWebApi.Entity
{
    public class Message
    {
        public int MessageId { get; set; } 
        public string? Name { get; set; } 
        public string? Email { get; set; } 
        public string? Subject { get; set; }
        public string? Detail { get; set; } 
        public DateTime SendDate { get; set; }
    }
}
