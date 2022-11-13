using Microsoft.AspNetCore.Mvc;

namespace AdminPanel.Controllers.Dashboard
{
    public class HelpdeskController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
