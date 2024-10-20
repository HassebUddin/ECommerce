

using ECommerce.Application.Messages;
using ECommerce.Domain.ViewModel.Request.Account;
using FluentValidation;

namespace ECommerce.Application.FluentValidator.Account
{
    public class ForgetPasswordValidator:AbstractValidator<ForgetPasswordRequest>
    {
        public ForgetPasswordValidator()
        {
            RuleFor(x => x.Email).NotEmpty().NotNull().WithMessage(FluentMessage.Required("Email"));

        }
    }
}
