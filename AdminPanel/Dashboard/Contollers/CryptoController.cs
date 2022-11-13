using Microsoft.AspNetCore.Mvc;

namespace AdminPanel.Dashboard
{
    public class CryptoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
