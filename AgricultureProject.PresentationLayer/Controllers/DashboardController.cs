using Microsoft.AspNetCore.Mvc;

namespace AgricultureProject.PresentationLayer.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
