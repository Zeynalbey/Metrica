using Microsoft.AspNetCore.Mvc;

namespace AdminPanel.Dashboard
{
    public class AnalyticsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
