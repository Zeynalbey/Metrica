using Microsoft.AspNetCore.Mvc;

namespace AdminPanel.Uikit.Controllers
{
    public class TablesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
