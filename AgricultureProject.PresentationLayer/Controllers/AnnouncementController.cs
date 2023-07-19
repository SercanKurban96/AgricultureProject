using AgricultureProject.BusinessLayer.Abstract;
using AgricultureProject.BusinessLayer.ValidationRules;
using AgricultureProject.EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace AgricultureProject.PresentationLayer.Controllers
{
    public class AnnouncementController : Controller
    {
        private readonly IAnnouncementServiceBL _announcementService;

        public AnnouncementController(IAnnouncementServiceBL announcementService)
        {
            _announcementService = announcementService;
        }

        AnnouncementValidator av = new AnnouncementValidator();

        public IActionResult Index()
        {
            var values = _announcementService.TGetListAll();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddAnnouncement()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddAnnouncement(Announcement announcement)
        {
            ValidationResult result = av.Validate(announcement);

            if (result.IsValid)
            {
                announcement.AnnouncementDate = DateTime.Parse(DateTime.Now.ToShortDateString());
                announcement.AnnouncementStatus = false;
                _announcementService.TInsert(announcement);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
        public IActionResult DeleteAnnouncement(int id)
        {
            var ann = _announcementService.TGetByID(id);
            _announcementService.TDelete(ann);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditAnnouncement(int id)
        {
            var ann = _announcementService.TGetByID(id);
            return View(ann);
        }
        [HttpPost]
        public IActionResult EditAnnouncement(Announcement announcement)
        {
            ValidationResult result = av.Validate(announcement);

            if (result.IsValid)
            {
                _announcementService.TUpdate(announcement);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
        public IActionResult ChangeStatusToTrue(int id)
        {
            _announcementService.AnnouncementStatusToTrue(id);
            return RedirectToAction("Index");
        }
        public IActionResult ChangeStatusToFalse(int id)
        {
            _announcementService.AnnouncementStatusToFalse(id);
            return RedirectToAction("Index");
        }
    }
}
