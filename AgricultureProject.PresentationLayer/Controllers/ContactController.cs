using AgricultureProject.BusinessLayer.Abstract;
using AgricultureProject.BusinessLayer.ValidationRules;
using AgricultureProject.EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace AgricultureProject.PresentationLayer.Controllers
{
    public class ContactController : Controller
    {
        private readonly IContactServiceBL _contactService;

        public ContactController(IContactServiceBL contactService)
        {
            _contactService = contactService;
        }
        ContactValidator cv = new ContactValidator();

        public IActionResult Index()
        {
            var values = _contactService.TGetListAll();
            return View(values);
        }

        public IActionResult DeleteMessage(int id)
        {
            var mes = _contactService.TGetByID(id);
            _contactService.TDelete(mes);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult MessageDetails(int id)
        {
            var mes = _contactService.TGetByID(id);
            return View(mes);
        }       
    }
}
