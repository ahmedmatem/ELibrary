using Microsoft.AspNetCore.Mvc;

namespace ELibrary.Web.Areas.Admin.Controllers
{
    public class HomeController : AdminBaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
