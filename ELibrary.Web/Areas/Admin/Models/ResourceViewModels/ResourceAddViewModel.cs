using System.ComponentModel.DataAnnotations;

namespace ELibrary.Web.Areas.Admin.Models.ResourceViewModels
{
    /// <summary>
    /// ViewModel for creating or editing a resource/book,
    /// includes file upload support via IFormFile.
    /// </summary>
    public class ResourceAddViewModel
    {
        public string? Id { get; set; } // optional, auto-generated when creating

        [Required]
        [StringLength(200, ErrorMessage = "Title cannot exceed 200 characters.")]
        [Display(Name = "Заглавие")]
        public string Title { get; set; } = "";

        [Required]
        [StringLength(100, ErrorMessage = "Subject cannot exceed 100 characters.")]
        [Display(Name = "Учебен предмет")]
        public string Subject { get; set; } = "";

        [StringLength(500, ErrorMessage = "Description cannot exceed 500 characters.")]
        [Display(Name = "Кратко описание")]
        public string Description { get; set; } = "";

        [Required]
        [Display(Name = "Формат")]
        public string Type { get; set; } = ""; // PDF, Video, Link, etc.

        /// <summary>
        /// For displaying already uploaded file path (if any).
        /// </summary>
        public string? FilePath { get; set; }

        /// <summary>
        /// The cover image path or URL for the resource.
        /// </summary>
        public string CoverImagePath { get; set; } = "";

        /// <summary>
        /// File to be uploaded (handled via form submission).
        /// </summary>
        [Display(Name = "Ресурс")]
        public IFormFile? File { get; set; }

        /// <summary>
        /// Cover Image File to be uploaded (handled via form submission).
        /// </summary>
        [Display(Name = "Корица")]
        public IFormFile? CoverImageFile { get; set; }
    }
}
