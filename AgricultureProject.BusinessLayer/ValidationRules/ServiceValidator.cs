using AgricultureProject.EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgricultureProject.BusinessLayer.ValidationRules
{
    public class ServiceValidator : AbstractValidator<Service>
    {
        public ServiceValidator()
        {
            RuleFor(x => x.ServiceTitle).NotEmpty().WithMessage("Başlık boş bırakılamaz.");
            RuleFor(x => x.ServiceDescription).NotEmpty().WithMessage("Açıklama boş bırakılamaz.");
            RuleFor(x => x.ServiceImageUrl).NotEmpty().WithMessage("Görsel boş bırakılamaz.");
            RuleFor(x => x.ServiceTitle).MinimumLength(3).WithMessage("Başlık en az 3 karakter olmalıdır..");
            RuleFor(x => x.ServiceTitle).MaximumLength(50).WithMessage("Başlık en fazla 50 karakter olmalıdır..");
        }
    }
}
