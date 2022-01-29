using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationsRolls
{
    public class EmployeeValidator : AbstractValidator<EmployeeUser>
    {
        public EmployeeValidator()
        {
            RuleFor(x => x.employeeUserName).NotEmpty().WithMessage("You cannot leave the User Name blank.");
            RuleFor(x => x.employeeUserName).MinimumLength(3).WithMessage("Name cannot be less than 3 characters");
            RuleFor(x => x.employeeUserName).MaximumLength(80).WithMessage("You cannot enter more than 80 characters.");

            RuleFor(x => x.employeeLastName).NotEmpty().WithMessage("You cannot leave the Last Name blank.");
            RuleFor(x => x.employeeLastName).MinimumLength(3).WithMessage("Last Name cannot be less than 3 characters");
            RuleFor(x => x.employeeLastName).MaximumLength(80).WithMessage("You cannot enter more than 80 characters.");

            RuleFor(x => x.employeeNikName).NotEmpty().WithMessage("You cannot leave the Full Name blank.");
            RuleFor(x => x.employeeNikName).MinimumLength(3).WithMessage("Nik Name cannot be less than 3 characters");
            RuleFor(x => x.employeeNikName).MaximumLength(80).WithMessage("You cannot enter more than 80 characters.");

            RuleFor(x => x.employeeEmail).NotEmpty().WithMessage("You cannot leave the Email Address blank.");
            RuleFor(x => x.employeeEmail).MinimumLength(3).WithMessage("Email cannot be less than 3 characters");
            RuleFor(x => x.employeeEmail).MaximumLength(80).WithMessage("You cannot enter more than 80 characters.");


            RuleFor(x => x.employeeMoneyAz).NotEmpty().WithMessage("You cannot leave the Minimun Salary blank.");
            RuleFor(x => x.employeeMoneyAz).MinimumLength(1).WithMessage("You cannot leave the Description blank.");
            RuleFor(x => x.employeeMoneyAz).MaximumLength(10).WithMessage("You cannot enter more than 10 characters.");


            RuleFor(x => x.employeeMobile).NotEmpty().WithMessage("You cannot leave the Mobile blank.");
            RuleFor(x => x.employeeMobile).MinimumLength(1).WithMessage("mobile cannot be less than 10 characters");
            RuleFor(x => x.employeeMobile).MaximumLength(15).WithMessage("You cannot enter more than 15 characters.");


            RuleFor(x => x.employeeSkills).NotEmpty().WithMessage("You cannot leave the Skills blank.");
            RuleFor(x => x.employeeSkills).MinimumLength(10).WithMessage("Skills cannot be less than 10 characters");
            RuleFor(x => x.employeeSkills).MaximumLength(200).WithMessage("You cannot enter more than 200 characters.");


            RuleFor(x => x.employeeAddress).NotEmpty().WithMessage("You cannot leave the Address blank.");
            RuleFor(x => x.employeeAddress).MinimumLength(10).WithMessage("Address cannot be less than 10 characters");
            RuleFor(x => x.employeeAddress).MaximumLength(250).WithMessage("You cannot enter more than 250 characters.");
        }
    }
}
