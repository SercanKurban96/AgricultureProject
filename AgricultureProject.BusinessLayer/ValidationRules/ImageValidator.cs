using AgricultureProject.EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgricultureProject.BusinessLayer.ValidationRules
{
    public class ImageValidator : AbstractValidator<Image>
    {
        public ImageValidator()
        {
            RuleFor(x => x.ImageTitle).NotEmpty().WithMessage("Görsel başlığı boş bırakılamaz.");
            RuleFor(x => x.ImageDescription).NotEmpty().WithMessage("Görsel açıklaması boş bırakılamaz.");
            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("Görsel yolu boş bırakılamaz.");
            RuleFor(x => x.ImageTitle).MinimumLength(3).WithMessage("Görsel başlığı en az 3 karakter olmalıdır.");
            RuleFor(x => x.ImageTitle).MaximumLength(20).WithMessage("Görsel başlığı en fazla 20 karakter olmalıdır.");
            RuleFor(x => x.ImageDescription).MinimumLength(5).WithMessage("Görsel açıklaması en az 3 karakter olmalıdır.");
            RuleFor(x => x.ImageDescription).MaximumLength(50).WithMessage("Görsel açıklaması en fazla 50 karakter olmalıdır.");
        }
    }
}
