namespace QuickStartWebUI.DTOs.Messages
{
    public class CreateMessageDto
    {
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Subject { get; set; }
        public string? Detail { get; set; }
        public DateTime SendDate { get; set; }
    }
}
