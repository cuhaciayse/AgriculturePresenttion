using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresenttion.ViewComponents
{
	public class _HeadPartial:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
