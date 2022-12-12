using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresenttion.ViewComponents
{
    public class _DashboardChartPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            ViewBag.v1 = 88;
            ViewBag.v2 = 70;
            return View();
        }
    }
}
