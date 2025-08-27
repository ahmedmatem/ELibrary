using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

using ELibrary.Infrastructure.Data.Types;

namespace ELibrary.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = AppRole.ADMIN)]
    public class AdminBaseController : Controller { }
}
