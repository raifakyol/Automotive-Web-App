using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.ValidationRules
{
    public class KullaniciValidator : AbstractValidator<Kullanici>
    {
        public KullaniciValidator()
        {
            RuleFor(W => W.Kullanici_AdSoyad).NotEmpty().WithMessage("Marka boş Geçilemez!");
            RuleFor(W => W.Marka).NotEmpty().WithMessage("Model boş Geçilemez!");
            RuleFor(W => W.Model).NotEmpty().WithMessage("Donanim boş Geçilemez!");
            RuleFor(W => W.Plaka).NotEmpty().WithMessage("Motor_hacmi boş Geçilemez!");
            RuleFor(W => W.Telefon).NotEmpty().WithMessage("Yakit_tipi boş Geçilemez!");
            RuleFor(W => W.Kullanici_Tarih).NotEmpty().WithMessage("Vites_tipi boş Geçilemez!");

        }
    }
}
