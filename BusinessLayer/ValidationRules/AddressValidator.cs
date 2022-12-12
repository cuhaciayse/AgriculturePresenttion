using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AddressValidator : AbstractValidator<Address>
    {
        public AddressValidator()
        {
            RuleFor(x => x.Descrition1).NotEmpty().WithMessage("Açıklama 1 boş geçilemez");
            RuleFor(x => x.Descrition2).NotEmpty().WithMessage("Açıklama 2 boş geçilemez");
            RuleFor(x => x.Descrition3).NotEmpty().WithMessage("Açıklama 3 boş geçilemez");
            RuleFor(x => x.Descrition4).NotEmpty().WithMessage("Açıklama 4 boş geçilemez");
            RuleFor(x => x.Mapinfo).NotEmpty().WithMessage("Harita bilgisi boş geçilemez");
        }
    }
}
