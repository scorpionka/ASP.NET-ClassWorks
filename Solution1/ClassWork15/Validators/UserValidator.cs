using ClassWork15.Models;
using FluentValidation;

namespace ClassWork15.Validators
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(x => x.FirstName)
                .NotEmpty()
                .WithMessage("First Name is required.")
                .MaximumLength(20).WithMessage("First Name can have a maximum of 20 characters.");

            RuleFor(x => x.LastName)
                .NotEmpty()
                .WithMessage("Please specify a last name.")
                .MaximumLength(30).WithMessage("Last Name can have a max of 30 characters.");

            RuleFor(x => x.NumberOfChildren)
                .ExclusiveBetween(0, 10)
                .WithMessage("The number of children varies from 0 to 10");

            RuleFor(x => x.Comments)
                .MaximumLength(4000)
                .WithMessage("Comments can have a maximum of 4000 characters.");

            RuleFor(x => x.Email)
                .EmailAddress()
                .WithMessage("Email is not valid");

        }
    }
}
}