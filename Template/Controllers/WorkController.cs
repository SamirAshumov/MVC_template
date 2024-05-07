using Microsoft.AspNetCore.Mvc;

namespace Template.Controllers
{
    public class WorkController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
