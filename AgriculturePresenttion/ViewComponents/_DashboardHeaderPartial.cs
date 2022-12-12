using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresenttion.ViewComponents
{
    public class _DashboardHeaderPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
