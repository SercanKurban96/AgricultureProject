using AgricultureProject.BusinessLayer.Abstract;
using AgricultureProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AgricultureProject.PresentationLayer.Controllers
{
    [AllowAnonymous]
    public class DefaultController : Controller
    {
        private readonly IContactServiceBL _contactService;

        public DefaultController(IContactServiceBL contactService)
        {
            _contactService = contactService;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public PartialViewResult SendMessage()
        {
            return PartialView();
        }
        [HttpPost]
        public IActionResult SendMessage(Contact contact)
        {
            contact.ContactDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            _contactService.TInsert(contact);
            return RedirectToAction("Index", "Default");
        }
        public PartialViewResult ScriptPartial()
        {
            return PartialView();
        }
    }
}
