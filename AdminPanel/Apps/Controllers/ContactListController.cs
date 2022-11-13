using Microsoft.AspNetCore.Mvc;

namespace AdminPanel.Apps.Controllers
{
    public class ContactListController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
