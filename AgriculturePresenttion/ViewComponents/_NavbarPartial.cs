using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresenttion.ViewComponents
{
	public class _NavbarPartial:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
