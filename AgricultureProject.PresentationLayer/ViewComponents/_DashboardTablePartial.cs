using AgricultureProject.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace AgricultureProject.PresentationLayer.ViewComponents
{
    public class _DashboardTablePartial : ViewComponent
    {
        private readonly IContactServiceBL _contactService;

        public _DashboardTablePartial(IContactServiceBL contactService)
        {
            _contactService = contactService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _contactService.TGetListAll();
            return View(values);
        }
    }
}
