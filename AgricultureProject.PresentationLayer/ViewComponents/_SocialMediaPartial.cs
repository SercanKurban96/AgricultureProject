using AgricultureProject.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace AgricultureProject.PresentationLayer.ViewComponents
{
	public class _SocialMediaPartial : ViewComponent
	{
		private readonly ISocialMediaServiceBL _socialMediaService;

		public _SocialMediaPartial(ISocialMediaServiceBL socialMediaService)
		{
			_socialMediaService = socialMediaService;
		}

		public IViewComponentResult Invoke()
		{
			var values = _socialMediaService.TGetListAll();
			return View(values);
		}
	}
}
