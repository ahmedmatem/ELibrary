namespace ELibrary.Core.DTOs
{
    /// <summary>
    /// Represents a data transfer object (DTO) for a resource, containing metadata and file information.
    /// </summary>
    /// <remarks>This class is typically used to transfer resource-related data between application layers or
    /// services. It includes properties for identifying the resource, describing its content, and tracking its upload
    /// details.</remarks>
    public class ResourceDto
    {
        public string Id { get; set; }
        public string Title { get; set; } = "";
        public string Subject { get; set; } = "";
        public string Description { get; set; } = "";
        public string Type { get; set; } = ""; 
        public string FilePath { get; set; } = "";
        public DateTime UploadedOn { get; set; }
    }
}
