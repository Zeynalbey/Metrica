using Microsoft.AspNetCore.Mvc;

namespace AdminPanel.Uikit.Controllers
{
    public class FormsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
