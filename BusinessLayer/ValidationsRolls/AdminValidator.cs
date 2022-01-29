using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationsRolls
{
    public class AdminValidator : AbstractValidator<AdminLar>
    {
        public AdminValidator()
        {
            RuleFor(x => x.AdminUserName).NotEmpty().WithMessage("You cannot leave the Usename blank.");
            RuleFor(x => x.AdminUserName).MinimumLength(3).WithMessage("Username cannot be less than 3 characters");
            RuleFor(x => x.AdminUserName).MaximumLength(90).WithMessage("You cannot enter more than 90 characters.");


            RuleFor(x => x.AdminPassword).NotEmpty().WithMessage("You cannot leave the Password blank.");
            RuleFor(x => x.AdminPassword).MinimumLength(3).WithMessage("Password cannot be less than 3 characters");
            RuleFor(x => x.AdminPassword).MaximumLength(90).WithMessage("You cannot enter more than 90 characters.");

            RuleFor(x => x.AdminLastName).NotEmpty().WithMessage("You cannot leave the Full Name blank.");
            RuleFor(x => x.AdminLastName).MinimumLength(3).WithMessage("Full Name cannot be less than 3 characters");
            RuleFor(x => x.AdminLastName).MaximumLength(90).WithMessage("You cannot enter more than 90 characters.");


            RuleFor(x => x.AdminEmail).NotEmpty().WithMessage("You cannot leave the Email blank.");
            RuleFor(x => x.AdminEmail).MinimumLength(15).WithMessage("Email cannot be less than 15 characters");
            RuleFor(x => x.AdminEmail).MaximumLength(90).WithMessage("You cannot enter more than 90 characters.");


        }
    }
}
