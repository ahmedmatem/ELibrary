using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

using ELibrary.Core.Contracts;
using ELibrary.Infrastructure.Data.Types;
using ELibrary.Web.Models;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;

namespace ELibrary.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IResourceService _resourceService;
        private readonly IAzureBlobService _blobService;
        private readonly IMapper _mapper;

        public HomeController(
            ILogger<HomeController> logger,
            IResourceService resourceService,
            IAzureBlobService blobService,
            IMapper mapper)
        {
            _logger = logger;
            _resourceService = resourceService;
            _blobService = blobService;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            if (User.IsInRole(AppRole.ADMIN))
            {
                return RedirectToAction("Index", "Home", new { area = "Admin" });
            }
            else if(User.IsInRole(AppRole.TEACHER))
            {
                return RedirectToAction("Index", "Home", new { area = "Teacher" });
            }
            else if (User.IsInRole(AppRole.STUDENT))
            {
                return RedirectToAction("Index", "Home", new { area = "Student"});
            }
            else
            {
                var viewModel = await _resourceService.GetAll()
                    .ProjectTo<ResourceViewModel>(_mapper.ConfigurationProvider)
                    .ToListAsync();

                return View(viewModel);
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
