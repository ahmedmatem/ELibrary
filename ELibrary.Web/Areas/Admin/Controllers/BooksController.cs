using Microsoft.AspNetCore.Mvc;

using AutoMapper;

namespace ELibrary.Web.Areas.Admin.Controllers
{
    public class BooksController : AdminBaseController
    {
        public BooksController(IMapper mapper) : base(mapper)
        {
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
