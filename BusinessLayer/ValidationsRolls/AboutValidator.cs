using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationsRolls
{
    public class AboutValidator : AbstractValidator<About>
    {
        public AboutValidator()
        {

            RuleFor(x => x.aboutDetails).NotEmpty().WithMessage("You cannot leave the Album text blank.");
            RuleFor(x => x.aboutDetails).MinimumLength(55).WithMessage("Album text cannot be less than 60 characters");
            RuleFor(x => x.aboutDetails).MaximumLength(900).WithMessage("You cannot enter more than 900 characters.");

            RuleFor(x => x.aboutPhotoUrl).NotEmpty().WithMessage("You cannot leave the Album text blank.");


        }

    }
}
