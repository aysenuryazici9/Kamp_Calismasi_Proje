using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator : AbstractValidator <Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar adını boş geçemezsiniz.");
            RuleFor(x => x.WriterSurName).NotEmpty().WithMessage("Yazar soyadını boş geçmeyiniz");
            RuleFor(x => x.WriterSurName).MinimumLength(2).WithMessage("En az 2 karakter girişi yapınız.");
            RuleFor(x => x.WriterSurName).MaximumLength(50).WithMessage("50 karakterden fazla değer girişi yapmayınız.");
            RuleFor(x => x.WriterTitle).NotEmpty().WithMessage("Unvan alanını boş geçmeyiniz");
        }
    }
}
