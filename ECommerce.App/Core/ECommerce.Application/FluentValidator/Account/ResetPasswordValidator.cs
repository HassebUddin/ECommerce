
using ECommerce.Application.Messages;
using ECommerce.Domain.ViewModel.Request.Account;
using FluentValidation;

namespace ECommerce.Application.FluentValidator.Account
{
    public class ResetPasswordValidator:AbstractValidator<ResetPasswordRequest>
    {
        public ResetPasswordValidator()
        {
            RuleFor(x => x.Email).NotEmpty().NotNull().WithMessage(FluentMessage.Required("Email"));
            RuleFor(x => x.NewPassword).NotEmpty().NotNull().WithMessage(FluentMessage.Required("New Password"));
            RuleFor(x => x.Token).NotEmpty().NotNull().WithMessage(FluentMessage.Required("Token"));


        }
    }
}
