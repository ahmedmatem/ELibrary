namespace ELibrary.Web.Models
{
    public class ResourceViewModel
    {
        public required string Id { get; set; }
        public string Title { get; set; } = "";
        public string Subject { get; set; } = "";
        public string Description { get; set; } = "";
        public string Type { get; set; } = "";
        public string FilePath { get; set; } = "";
        public string CoverImagePath { get; set; } = "";
        public DateTime UploadedOn { get; set; }
    }
}
