using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationsRolls
{
     public class CategoryValidator : AbstractValidator<Catagory>
    {
        public CategoryValidator()
        {
            RuleFor(x => x.catagoryName).NotEmpty().WithMessage("You cannot leave the name blank.");
            RuleFor(x => x.catagoryName).MinimumLength(3).WithMessage("Name cannot be less than 3 characters");
            RuleFor(x => x.catagoryName).MaximumLength(90).WithMessage("You cannot enter more than 90 characters.");

            RuleFor(x => x.catagoryAciklama).NotEmpty().WithMessage("You cannot leave the Description blank.");
            
            RuleFor(x => x.catagoryAciklama).MinimumLength(40).WithMessage("Description cannot be less than 40 characters");
            RuleFor(x => x.catagoryAciklama).MaximumLength(500).WithMessage("You cannot enter more than 500 characters.");
        }
    }
}
