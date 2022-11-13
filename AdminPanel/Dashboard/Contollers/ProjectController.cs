using Microsoft.AspNetCore.Mvc;

namespace AdminPanel.Controllers.Dashboard
{
    public class ProjectController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
