using System.ComponentModel.DataAnnotations;

namespace ELibrary.Web.Models
{
    public class ResourceViewModel
    {
        public required string Id { get; set; }
        [Required]
        [Display(Name = "Заглавие")]
        public string Title { get; set; } = "";
        [Required]
        [Display(Name = "Учебен предмет")]
        public string Subject { get; set; } = "";
        [Display(Name = "Описание")]
        public string Description { get; set; } = "";
        [Display(Name = "Формат")]
        public string Type { get; set; } = "";
        [Display(Name = "Ресурс")]
        public string FilePath { get; set; } = "";
        [Display(Name = "Корица")]
        public string CoverImagePath { get; set; } = "";
        public DateTime UploadedOn { get; set; }
    }
}
