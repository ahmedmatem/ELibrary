using System.Diagnostics;

using Microsoft.AspNetCore.Mvc;

using ELibrary.Web.Models;
using System.Runtime.CompilerServices;
using Microsoft.AspNetCore.Identity;
using ELibrary.Infrastructure.Data.Types;

namespace ELibrary.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
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
                return View();
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
