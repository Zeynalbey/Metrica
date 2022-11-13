using Microsoft.AspNetCore.Mvc;

namespace AdminPanel.Controllers.Dashboard
{
    public class EcommerceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
