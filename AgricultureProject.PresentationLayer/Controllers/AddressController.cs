using AgricultureProject.BusinessLayer.Abstract;
using AgricultureProject.BusinessLayer.ValidationRules;
using AgricultureProject.EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace AgricultureProject.PresentationLayer.Controllers
{
    public class AddressController : Controller
    {
        private readonly IAddressServiceBL _addressService;

        public AddressController(IAddressServiceBL addressService)
        {
            _addressService = addressService;
        }

        AddressValidator adv = new AddressValidator();

        public IActionResult Index()
        {
            var values = _addressService.TGetListAll();
            return View(values);
        }
        
        [HttpGet]
        public IActionResult EditAddress(int id)
        {
            var add = _addressService.TGetByID(id);
            return View(add);
        }
        [HttpPost]
        public IActionResult EditAddress(Address address)
        {
            ValidationResult result = adv.Validate(address);

            if (result.IsValid)
            {
                _addressService.TUpdate(address);
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
