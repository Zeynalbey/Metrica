using Microsoft.AspNetCore.Mvc;

namespace AdminPanel.Apps.Controllers
{
    public class ChatController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
