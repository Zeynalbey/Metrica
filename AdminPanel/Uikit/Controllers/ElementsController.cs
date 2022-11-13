using Microsoft.AspNetCore.Mvc;

namespace AdminPanel.Uikit.Controllers
{
    public class ElementsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
