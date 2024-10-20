
using ECommerce.Application.Messages;
using ECommerce.Domain.ViewModel.Request.Account;
using FluentValidation;

namespace ECommerce.Application.FluentValidator.Account
{
    public class LoginValidator:AbstractValidator<LoginRequest>
    {
        public LoginValidator()
        {
            RuleFor(x => x.Email).NotEmpty().NotNull().WithMessage(FluentMessage.Required("Email"));
            RuleFor(x => x.Password).NotEmpty().NotNull().WithMessage(FluentMessage.Required("Password"));

        }
    }
}
