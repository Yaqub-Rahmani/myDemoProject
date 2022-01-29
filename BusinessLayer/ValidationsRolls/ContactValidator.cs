using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationsRolls
{
   public class ContactValidator : AbstractValidator<Contect>
    {
        public ContactValidator()
        {
            RuleFor(x => x.contectName).NotEmpty().WithMessage("You cannot leave the Name blank.");
            RuleFor(x => x.contectName).MinimumLength(3).WithMessage("Name cannot be less than 3 characters");
            RuleFor(x => x.contectName).MaximumLength(90).WithMessage("You cannot enter more than 90 characters.");

            RuleFor(x => x.contectSubject).NotEmpty().WithMessage("You cannot leave the Subject blank.");
            RuleFor(x => x.contectSubject).MinimumLength(3).WithMessage("Subject cannot be less than 3 characters");
            RuleFor(x => x.contectSubject).MaximumLength(90).WithMessage("You cannot enter more than 90 characters.");

            RuleFor(x => x.contectEmail).NotEmpty().WithMessage("You cannot leave the Email blank.");
            RuleFor(x => x.contectEmail).MinimumLength(3).WithMessage("Email cannot be less than 3 characters");
            RuleFor(x => x.contectEmail).MaximumLength(90).WithMessage("You cannot enter more than 90 characters.");

            RuleFor(x => x.contectMessage).NotEmpty().WithMessage("You cannot leave the Message blank.");
            RuleFor(x => x.contectMessage).MinimumLength(50).WithMessage("Message cannot be less than 50 characters");
            RuleFor(x => x.contectMessage).MaximumLength(1500).WithMessage("You cannot enter more than 1500 characters.");

        }

    }
}
