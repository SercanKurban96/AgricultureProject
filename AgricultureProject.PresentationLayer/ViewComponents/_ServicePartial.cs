using AgricultureProject.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace AgricultureProject.PresentationLayer.ViewComponents
{
    public class _ServicePartial : ViewComponent
    {
        private readonly IServiceServiceBL _serviceService;

        public _ServicePartial(IServiceServiceBL serviceService)
        {
            _serviceService = serviceService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _serviceService.TGetListAll();
            return View(values);
        }
    }
}
