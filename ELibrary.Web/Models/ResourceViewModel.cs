namespace ELibrary.Web.Models
{
    public class ResourceViewModel
    {
        public Guid Id { get; set; }
        public string Title { get; set; } = "";
        public string Subject { get; set; } = "";
        public string Description { get; set; } = "";
        public string Type { get; set; } = "";
        public string FilePath { get; set; } = "";
        public DateTime UploadedOn { get; set; }
    }
}
