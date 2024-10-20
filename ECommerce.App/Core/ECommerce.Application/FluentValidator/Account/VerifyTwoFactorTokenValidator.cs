

using ECommerce.Application.Messages;
using ECommerce.Domain.ViewModel.Request.Account;
using FluentValidation;

namespace ECommerce.Application.FluentValidator.Account
{
    public class VerifyTwoFactorTokenValidator : AbstractValidator<VerifyTwoFactorTokenRequest>
    {
        public VerifyTwoFactorTokenValidator()
        {
            RuleFor(x => x.Email).NotEmpty().NotNull().WithMessage(FluentMessage.Required("Email"));
            RuleFor(x => x.Token).NotEmpty().NotNull().WithMessage(FluentMessage.Required("Token"));
        }
    }
}
