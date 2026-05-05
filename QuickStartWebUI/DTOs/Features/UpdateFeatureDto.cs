namespace QuickStartWebUI.DTOs.Features
{
    public class UpdateFeatureDto
    {
        public int FeatureId { get; set; }
        public int Number { get; set; }
        public string? Title { get; set; }
        public string? IconUrl { get; set; }
    }
}
