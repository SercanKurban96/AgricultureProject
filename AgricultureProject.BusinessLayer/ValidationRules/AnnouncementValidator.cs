using AgricultureProject.EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgricultureProject.BusinessLayer.ValidationRules
{
    public class AnnouncementValidator : AbstractValidator<Announcement>
    {
        public AnnouncementValidator()
        {
            RuleFor(x=>x.AnnouncementTitle).NotEmpty().WithMessage("Duyuru başlığı boş bırakılamaz.");
            RuleFor(x=>x.AnnouncementDescription).NotEmpty().WithMessage("Duyuru açıklaması boş bırakılamaz.");
            RuleFor(x => x.AnnouncementTitle).MinimumLength(3).WithMessage("Duyuru başlığı en az 3 karakter olmalıdır.");
            RuleFor(x => x.AnnouncementTitle).MaximumLength(100).WithMessage("Duyuru başlığı en fazla 100 karakter olmalıdır.");
        }
    }
}
