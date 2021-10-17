using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManager.Domain.Entities;

namespace UserManager.Service.Validators
{
    public class UserValidator: AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(c => c.Name)
                .NotEmpty().WithMessage("Please enter the name.")
                .NotNull().WithMessage("Please enter the name.");

            RuleFor(c => c.Email)
                .NotEmpty().WithMessage("Please enter the email.")
                .NotNull().WithMessage("Please enter the email.");

            RuleFor(c => c.BirthDate)
                .NotEmpty().WithMessage("Please enter the birthdate.")
                .NotNull().WithMessage("Please enter the birthdate.");

            RuleFor(c => c.Scholarity)
                .NotEmpty().WithMessage("Please enter the scholarity.")
                .NotNull().WithMessage("Please enter the scholarity.");
        }
    }
}
