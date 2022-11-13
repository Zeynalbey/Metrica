using Microsoft.AspNetCore.Mvc;

namespace AdminPanel.Apps.Controllers
{
    public class InvoiceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
