using Microsoft.AspNetCore.Mvc;

namespace Manero.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["BackToHomeLink"] = "<a asp-controller=\"home\" asp-action=\"index\"></a>";
            return View("Index");
        }

    }
}
