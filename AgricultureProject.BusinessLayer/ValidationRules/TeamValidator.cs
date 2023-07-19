using AgricultureProject.EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgricultureProject.BusinessLayer.ValidationRules
{
    public class TeamValidator : AbstractValidator<Team>
    {
        public TeamValidator()
        {
            RuleFor(x => x.PersonName).NotEmpty().WithMessage("Ad soyad boş bırakılamaz.");
            RuleFor(x => x.PersonTitle).NotEmpty().WithMessage("Görev boş bırakılamaz.");
            RuleFor(x => x.PersonImageUrl).NotEmpty().WithMessage("Görsel boş bırakılamaz.");
            RuleFor(x => x.PersonName).MinimumLength(5).WithMessage("En az 5 karakter girilmelidir.");
            RuleFor(x => x.PersonName).MaximumLength(100).WithMessage("En fazla 100 karakter girilmelidir.");
            RuleFor(x => x.PersonTitle).MinimumLength(4).WithMessage("En az 4 karakter girilmelidir.");
            RuleFor(x => x.PersonTitle).MaximumLength(100).WithMessage("En fazla 100 karakter girilmelidir.");
        }
    }
}
