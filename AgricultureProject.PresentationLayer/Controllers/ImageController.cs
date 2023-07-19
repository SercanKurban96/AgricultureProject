using AgricultureProject.BusinessLayer.Abstract;
using AgricultureProject.BusinessLayer.ValidationRules;
using AgricultureProject.EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace AgricultureProject.PresentationLayer.Controllers
{
    public class ImageController : Controller
    {
        private readonly IImageServiceBL _imageService;

        public ImageController(IImageServiceBL imageService)
        {
            _imageService = imageService;
        }

        ImageValidator iv = new ImageValidator();

        public IActionResult Index()
        {
            var values = _imageService.TGetListAll();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddImage()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddImage(Image image)
        {
            ValidationResult result = iv.Validate(image);

            if (result.IsValid)
            {
                _imageService.TInsert(image);
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
        public IActionResult DeleteImage(int id)
        {
            var image = _imageService.TGetByID(id);
            _imageService.TDelete(image);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditImage(int id)
        {
            var image = _imageService.TGetByID(id);
            return View(image);
        }
        [HttpPost]
        public IActionResult EditImage(Image image)
        {
            ValidationResult result = iv.Validate(image);

            if (result.IsValid)
            {
                _imageService.TUpdate(image);
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
