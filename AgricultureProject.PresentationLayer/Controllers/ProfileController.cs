using AgricultureProject.PresentationLayer.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AgricultureProject.PresentationLayer.Controllers
{
    public class ProfileController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;

        public ProfileController(UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);

            UserEditViewModel model = new UserEditViewModel();
            model.Mail = values.Email;
            model.Phone = values.PhoneNumber;

            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Index(UserEditViewModel p)
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);

            if (p.Password == p.ConfirmPassword)
            {
                values.Email = p.Mail;
                values.PhoneNumber = p.Phone;
                values.PasswordHash = _userManager.PasswordHasher.HashPassword(values, p.Password);

                var result = await _userManager.UpdateAsync(values);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Login");
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }
            }
            return View();
        }
    }
}
