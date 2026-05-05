namespace QuickStartWebUI.DTOs.Abouts
{
    public class UpdateAboutDto
    {
        public int AboutId { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? ImageUrl { get; set; }
        public string? Options1 { get; set; }
        public string? Options2 { get; set; }
    }
}
