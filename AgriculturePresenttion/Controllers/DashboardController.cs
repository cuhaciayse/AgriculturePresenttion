using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresenttion.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
