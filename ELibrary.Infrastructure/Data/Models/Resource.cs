using ELibrary.Infrastructure.Data.Contracts;
using ELibrary.Infrastructure.Data.Types;
using System.ComponentModel.DataAnnotations;

namespace ELibrary.Infrastructure.Data.Models
{
    /// <summary>
    /// Represents a learning resource (PDF, Video, or Link) stored in the virtual library.
    /// </summary>
    public class Resource : DataModel
    {
        /// <summary>
        /// The title of the resource. Required and limited to 200 characters.
        /// </summary>
        [Required]
        [StringLength(200, ErrorMessage = "Title cannot exceed 200 characters.")]
        public string Title { get; set; } = "";

        /// <summary>
        /// The subject or category (e.g., Math, Science) this resource belongs to.
        /// </summary>
        [Required]
        [StringLength(100, ErrorMessage = "Subject cannot exceed 100 characters.")]
        public string Subject { get; set; } = "";

        /// <summary>
        /// A brief description of the resource.
        /// </summary>
        [StringLength(1000, ErrorMessage = "Description cannot exceed 1000 characters.")]
        public string Description { get; set; } = "";

        /// <summary>
        /// The type of resource (e.g., PDF, Video, Link).
        /// </summary>
        [Required]
        public ResourceType Type { get; set; } // Enum: PDF, Video, Link

        /// <summary>
        /// The file path or URL where this resource can be accessed.
        /// </summary>
        [Required]
        [StringLength(500, ErrorMessage = "File path or URL cannot exceed 500 characters.")]
        public string FilePath { get; set; } = ""; // Could be a URL or file path

        /// <summary>
        /// The cover image path or URL for the resource.
        /// </summary>
        [StringLength(500, ErrorMessage = "Cover image path or URL cannot exceed 500 characters.")]
        public string? CoverImagePath { get; set; }

        /// <summary>
        /// The date and time when the resource was uploaded to the library.
        /// Defaults to UTC now.
        /// </summary>
        [Required]
        public DateTime UploadedOn { get; set; } = DateTime.UtcNow;
    }
}
