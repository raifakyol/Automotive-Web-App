using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete;
using FluentValidation;
namespace BusinessLayer.ValidationRules
{
    public class AracValidator:AbstractValidator<Arac>
    {
        public AracValidator()
        {
            RuleFor(W => W.Marka).NotEmpty().WithMessage("Marka boş Geçilemez!");
            RuleFor(W => W.Model).NotEmpty().WithMessage("Model boş Geçilemez!");
            RuleFor(W => W.Donanim).NotEmpty().WithMessage("Donanim boş Geçilemez!");
            RuleFor(W => W.Motor_hacmi).NotEmpty().WithMessage("Motor_hacmi boş Geçilemez!");
            RuleFor(W => W.Yakit_tipi).NotEmpty().WithMessage("Yakit_tipi boş Geçilemez!");
            RuleFor(W => W.Vites_tipi).NotEmpty().WithMessage("Vites_tipi boş Geçilemez!");
            RuleFor(W => W.AracBg).NotEmpty().WithMessage("AracBg boş Geçilemez!");
            RuleFor(w => w.Fiyat).NotEmpty().WithMessage("Fiyat boş Geçilemez!");

        }

    }
}
