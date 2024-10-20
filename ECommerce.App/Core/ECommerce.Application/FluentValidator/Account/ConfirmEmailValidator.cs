

using ECommerce.Application.Messages;
using ECommerce.Domain.ViewModel.Request.Account;
using FluentValidation;

namespace ECommerce.Application.FluentValidator.Account
{
    internal class ConfirmEmailValidator : AbstractValidator<ConfirmEmailRequest>
    {
        public ConfirmEmailValidator()
        {
            RuleFor(x => x.Email).NotEmpty().NotNull().WithMessage(FluentMessage.Required("Email"));
            RuleFor(x => x.Token).NotEmpty().NotNull().WithMessage(FluentMessage.Required("Token"));
        }
    }
}
