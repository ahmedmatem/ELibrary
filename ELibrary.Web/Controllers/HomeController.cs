using System.ComponentModel.Design;
using System.Diagnostics;
using ELibrary.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace ELibrary.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IResourceService rs;

        public HomeController(ILogger<HomeController> logger, IResourceService rs)
        {
            this.rs = rs;
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
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
