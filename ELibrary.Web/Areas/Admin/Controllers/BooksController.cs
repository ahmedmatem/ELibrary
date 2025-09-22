using Microsoft.AspNetCore.Mvc;

using AutoMapper;

using ELibrary.Core.Contracts;
using ELibrary.Web.Areas.Admin.Models.ResourceViewModels;
using static ELibrary.Infrastructure.Data.DataConstants;
using System.Threading.Tasks;
using ELibrary.Core.DTOs;


namespace ELibrary.Web.Areas.Admin.Controllers
{
    public class BooksController : AdminBaseController
    {
        private readonly IAzureBlobService _azureBlobService;
        private readonly IResourceService _resourceService;

        public BooksController(
            IAzureBlobService azureBlobService, 
            IResourceService resourceService,
            IMapper mapper) : base(mapper)
        {
            _azureBlobService = azureBlobService;
            _resourceService = resourceService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(ResourceAddViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            if(model.File is not null)
            {
                if(model.File.Length == 0 || model.File.Length > RESOURCE_FILE_MAX_SIZE)
                {
                    ModelState.AddModelError(nameof(model.File), "Файлът е празен или твърде голям (макс. 20МВ)");
                    return View(model);
                }

                // Allow only some extensions
                var ext = Path.GetExtension(model.File.FileName).ToLowerInvariant();
                if (!RESOURCE_FILE_ALLOWED_EXTENSIONS.Contains(ext))
                {
                    ModelState.AddModelError(nameof(model.File), "Неподдържан файлов формат.");
                    return View(model);
                }

                var blobName = Guid.NewGuid().ToString() + ext;

                // set FilePath & save
                model.FilePath = _azureBlobService.BlobContainerUrl + blobName;
                await _azureBlobService.UploadFileAsync(model.File, blobName);
                
            }

            var resourceDto = mapper.Map<ResourceDto>(model);
            await _resourceService.AddAsync(resourceDto);

            return RedirectToAction(nameof(Index));
        }
    }
}
