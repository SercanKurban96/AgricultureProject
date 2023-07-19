using AgricultureProject.EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgricultureProject.BusinessLayer.ValidationRules
{
    public class AddressValidator : AbstractValidator<Address>
    {
        public AddressValidator()
        {
            RuleFor(x => x.AddressDescription1).NotEmpty().WithMessage("Açıklama 1 boş bırakılamaz.");
            RuleFor(x => x.AddressDescription2).NotEmpty().WithMessage("Açıklama 2 boş bırakılamaz.");
            RuleFor(x => x.AddressDescription3).NotEmpty().WithMessage("Açıklama 3 boş bırakılamaz.");
            RuleFor(x => x.AddressDescription4).NotEmpty().WithMessage("Açıklama 4 boş bırakılamaz.");
            RuleFor(x => x.AddressMapInfo).NotEmpty().WithMessage("Harita bilgisi boş bırakılamaz.");
            RuleFor(x => x.AddressDescription1).MaximumLength(45).WithMessage("Açıklama 1 en fazla 45 karakter olmalıdır.");
            RuleFor(x => x.AddressDescription2).MaximumLength(45).WithMessage("Açıklama 2 en fazla 25 karakter olmalıdır.");
            RuleFor(x => x.AddressDescription3).MaximumLength(45).WithMessage("Açıklama 3 en fazla 45 karakter olmalıdır.");
            RuleFor(x => x.AddressDescription4).MaximumLength(45).WithMessage("Açıklama 4 en fazla 45 karakter olmalıdır.");
        }
    }
}
