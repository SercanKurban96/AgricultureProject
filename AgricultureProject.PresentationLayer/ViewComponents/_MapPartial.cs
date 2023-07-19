using AgricultureProject.BusinessLayer.Abstract;
using AgricultureProject.DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace AgricultureProject.PresentationLayer.ViewComponents
{
    public class _MapPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            Context c = new Context();
            var values = c.Addresses.Select(x=>x.AddressMapInfo).FirstOrDefault();
            ViewBag.v = values;
            return View();
        }
    }
}
