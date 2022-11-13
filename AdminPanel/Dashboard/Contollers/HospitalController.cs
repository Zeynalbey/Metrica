using Microsoft.AspNetCore.Mvc;

namespace AdminPanel.Controllers.Dashboard
{
    public class HospitalController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
