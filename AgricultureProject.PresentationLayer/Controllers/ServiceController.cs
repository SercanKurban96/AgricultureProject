using AgricultureProject.BusinessLayer.Abstract;
using AgricultureProject.BusinessLayer.ValidationRules;
using AgricultureProject.EntityLayer.Concrete;
using AgricultureProject.PresentationLayer.Models;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace AgricultureProject.PresentationLayer.Controllers
{
    public class ServiceController : Controller
    {
        private readonly IServiceServiceBL _serviceService;

        public ServiceController(IServiceServiceBL serviceService)
        {
            _serviceService = serviceService;
        }
        ServiceValidator sv = new ServiceValidator();

        public IActionResult Index()
        {
            var values = _serviceService.TGetListAll();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddService()
        {
            return View(new ServiceAddViewModel());
        }
        [HttpPost]
        public IActionResult AddService(Service service)
        {
            ValidationResult result = sv.Validate(service);

            if (result.IsValid)
            {
                _serviceService.TInsert(service);
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
        public IActionResult DeleteService(int id)
        {
            var srv = _serviceService.TGetByID(id);
            _serviceService.TDelete(srv);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditService(int id)
        {
            var srv = _serviceService.TGetByID(id);
            return View(srv);
        }
        [HttpPost]
        public IActionResult EditService(Service service)
        {
            ValidationResult result = sv.Validate(service);

            if (result.IsValid)
            {
                _serviceService.TUpdate(service);
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
    }
}
