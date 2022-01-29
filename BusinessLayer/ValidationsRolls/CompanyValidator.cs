using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationsRolls
{
    public class CompanyValidator : AbstractValidator<Company>
    {
        public CompanyValidator()
        {
            RuleFor(x => x.companyName).NotEmpty().WithMessage("You cannot leave the name blank.");
            RuleFor(x => x.companyName).MinimumLength(3).WithMessage("Company Name cannot be less than 3 characters");
            RuleFor(x => x.companyName).MaximumLength(90).WithMessage("You cannot enter more than 90 characters.");

            RuleFor(x => x.companyBoss).NotEmpty().WithMessage("You cannot leave the Description blank.");
            RuleFor(x => x.companyBoss).MinimumLength(3).WithMessage("Owner Name cannot be less than 3 characters");
            RuleFor(x => x.companyBoss).MaximumLength(80).WithMessage("You cannot enter more than 80 characters.");

        }
        
    }
}
