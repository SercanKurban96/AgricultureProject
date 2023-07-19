using AgricultureProject.EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgricultureProject.BusinessLayer.ValidationRules
{
    public class ContactValidator : AbstractValidator<Contact>
    {
        public ContactValidator()
        {
            RuleFor(x => x.ContactName).NotEmpty().WithMessage("Ad soyad boş bırakılamaz.");
            RuleFor(x => x.ContactMail).NotEmpty().WithMessage("Mail adresi boş bırakılamaz.");
            RuleFor(x => x.ContactDate).NotEmpty().WithMessage("Tarih boş bırakılamaz.");
            RuleFor(x => x.ContactMessage).NotEmpty().WithMessage("Mesaj boş bırakılamaz.");
        }
    }
}
