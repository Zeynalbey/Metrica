using Microsoft.AspNetCore.Mvc;

namespace AdminPanel.Pages.Controllers
{
    public class StarterPageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
