using AgricultureProject.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace AgricultureProject.PresentationLayer.ViewComponents
{
    public class _AddressPartial : ViewComponent
    {
        private readonly IAddressServiceBL _addressService;

        public _AddressPartial(IAddressServiceBL addressService)
        {
            _addressService = addressService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _addressService.TGetListAll();
            return View(values);
        }
    }
}
