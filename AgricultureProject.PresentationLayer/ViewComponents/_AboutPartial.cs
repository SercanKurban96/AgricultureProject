using AgricultureProject.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace AgricultureProject.PresentationLayer.ViewComponents
{
    public class _AboutPartial : ViewComponent
    {
        private readonly IAboutServiceBL _aboutService;

        public _AboutPartial(IAboutServiceBL aboutService)
        {
            _aboutService = aboutService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _aboutService.TGetListAll();
            return View(values);
        }
    }
}
