

using ECommerce.Application.Messages;
using ECommerce.Domain.ViewModel.Request.Identity.Role;
using FluentValidation;

namespace ECommerce.Application.FluentValidator.Identity.Role
{
    public class RoleCreateValidator : AbstractValidator<RoleCreateRequest>
    {
        public RoleCreateValidator()
        {
            RuleFor(x => x.Name).NotEmpty().NotNull().WithMessage(FluentMessage.Required("Name"));
          

        }
    }
 
}
