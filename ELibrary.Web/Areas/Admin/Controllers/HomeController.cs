using Microsoft.AspNetCore.Mvc;

using AutoMapper;

namespace ELibrary.Web.Areas.Admin.Controllers
{
    public class HomeController : AdminBaseController
    {
        public HomeController(IMapper mapper) : base(mapper)
        {
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
