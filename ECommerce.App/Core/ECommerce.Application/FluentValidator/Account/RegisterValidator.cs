
using ECommerce.Application.Messages;
using ECommerce.Domain.ViewModel.Request.Account;
using FluentValidation;

namespace ECommerce.Application.FluentValidator.Account
{
    public class RegisterValidator:AbstractValidator<RegisterRequest>
    {
        public RegisterValidator()
        {
            RuleFor(x => x.Email).NotEmpty().NotNull().WithMessage(FluentMessage.Required("Email"));
            RuleFor(x => x.Password).NotEmpty().NotNull().WithMessage(FluentMessage.Required("Password"));
            RuleFor(x => x.FullName).NotEmpty().NotNull().WithMessage(FluentMessage.Required("FullName"));
            RuleFor(x => x.Gender).NotEmpty().NotNull().WithMessage(FluentMessage.Required("Gender"));
            RuleFor(x => x.Address).NotEmpty().NotNull().WithMessage(FluentMessage.Required("Address"));
            RuleFor(x => x.Profession).NotEmpty().NotNull().WithMessage(FluentMessage.Required("Profession"));
            RuleFor(x => x.Country).NotEmpty().NotNull().WithMessage(FluentMessage.Required("Country"));
            RuleFor(x => x.City).NotEmpty().NotNull().WithMessage(FluentMessage.Required("City"));

            RuleFor(x => x.Email).EmailAddress().WithMessage(FluentMessage.EmailAddress());

        }
    }
}
