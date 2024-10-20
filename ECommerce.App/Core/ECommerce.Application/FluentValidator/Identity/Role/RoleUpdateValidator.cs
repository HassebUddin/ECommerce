
using ECommerce.Application.Messages;
using ECommerce.Domain.ViewModel.Request.Identity.Role;
using FluentValidation;

namespace ECommerce.Application.FluentValidator.Identity.Role
{
    public class RoleUpdateValidator:AbstractValidator<RoleUpdateRequest>
    {
        public RoleUpdateValidator()
        {
            RuleFor(x => x.Name).NotEmpty().NotNull().WithMessage(FluentMessage.Required("Name"));
            RuleFor(x => x.Id).NotEmpty().NotNull().WithMessage(FluentMessage.Required("RoleId"));

        }
    }
}
