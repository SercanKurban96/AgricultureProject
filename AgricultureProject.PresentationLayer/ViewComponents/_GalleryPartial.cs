using AgricultureProject.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace AgricultureProject.PresentationLayer.ViewComponents
{
    public class _GalleryPartial : ViewComponent
    {
        private readonly IImageServiceBL _imageService;

        public _GalleryPartial(IImageServiceBL imageService)
        {
            _imageService = imageService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _imageService.TGetListAll();
            return View(values);
        }
    }
}
