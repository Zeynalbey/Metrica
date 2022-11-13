using Microsoft.AspNetCore.Mvc;

namespace AdminPanel.Apps.Controllers
{
    public class CalendarController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
