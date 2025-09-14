using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

using AutoMapper;

using ELibrary.Infrastructure.Data.Types;

namespace ELibrary.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = AppRole.ADMIN)]
    public class AdminBaseController : Controller 
    {
        protected readonly IMapper mapper;

        public AdminBaseController(IMapper mapper) 
        {
            this.mapper = mapper;
        }
    }
}
