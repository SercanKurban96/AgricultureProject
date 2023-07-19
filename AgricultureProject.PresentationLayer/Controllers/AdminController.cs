using AgricultureProject.BusinessLayer.Abstract;
using AgricultureProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace AgricultureProject.PresentationLayer.Controllers
{
    public class AdminController : Controller
    {
        private readonly IAdminServiceBL _adminService;

        public AdminController(IAdminServiceBL adminService)
        {
            _adminService = adminService;
        }

        public IActionResult Index()
        {
            var values = _adminService.TGetListAll();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddAdmin()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddAdmin(Admin admin)
        {
            _adminService.TInsert(admin);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteAdmin(int id)
        {
            var admin = _adminService.TGetByID(id);
            _adminService.TDelete(admin);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditAdmin(int id)
        {
            var admin = _adminService.TGetByID(id);
            return View(admin);
        }

        [HttpPost]
        public IActionResult EditAdmin(Admin admin)
        {
            _adminService.TUpdate(admin);
            return RedirectToAction("Index");
        }
    }
}
