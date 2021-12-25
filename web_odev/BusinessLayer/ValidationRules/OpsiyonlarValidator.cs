using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete;
using FluentValidation;
namespace BusinessLayer.ValidationRules
{
    public class OpsiyonlarValidator : AbstractValidator<Opsiyonlar>
    {
        public OpsiyonlarValidator()
        {
            RuleFor(W => W.Opsiyon_Adi).NotEmpty().WithMessage("Opsiyon Adı boş Geçilemez!");
            RuleFor(W => W.Opsiyon_Fiyati).NotEmpty().WithMessage("Opsiyon Fiyatı boş Geçilemez!");
        }

    }
}
