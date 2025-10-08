using ELibrary.Core.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace ELibrary.Web.Controllers
{
    public class BooksController : Controller
    {
        private readonly IAzureBlobService _azureBlobService;

        public BooksController(IAzureBlobService blobService) 
        {
            _azureBlobService = blobService;
        }

        [HttpGet("books/pdf/{fileName}")]
        public async Task<IActionResult> Pdf(string fileName)
        {
            if (fileName is null)
            {
                return NotFound();
            }

            var stream = await _azureBlobService.OpenReadAsync(fileName);
            return File(stream, "application/pdf", enableRangeProcessing: true);
        }
    }
}
