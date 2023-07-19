using AgricultureProject.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace AgricultureProject.PresentationLayer.ViewComponents
{
    public class _AnnouncementPartial : ViewComponent
    {
        private readonly IAnnouncementServiceBL _announcementService;

        public _AnnouncementPartial(IAnnouncementServiceBL announcementService)
        {
            _announcementService = announcementService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _announcementService.TGetListAll();
            return View(values);
        }
    }
}
