using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AdminValidator : AbstractValidator<Admin>
    {
        public AdminValidator()
        {
            RuleFor(W => W.Admin_UserName).NotEmpty().WithMessage("Marka boş Geçilemez!");
            RuleFor(W => W.Password).NotEmpty().WithMessage("Model boş Geçilemez!");
        }
    }
}
