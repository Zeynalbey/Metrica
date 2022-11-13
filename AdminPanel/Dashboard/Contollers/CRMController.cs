using Microsoft.AspNetCore.Mvc;

namespace AdminPanel.Controllers.Dashboard
{
    public class CRMController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
