

using ECommerce.Application.Messages;
using ECommerce.Domain.ViewModel.Request.Identity.User;
using FluentValidation;

namespace ECommerce.Application.FluentValidator.Identity.User
{
    public class UserUpdateValidator:AbstractValidator<UserUpdateRequest>
    {
        public UserUpdateValidator()
        {
            RuleFor(x => x.Id).NotEmpty().NotNull().WithMessage(FluentMessage.Required("UserId"));
            RuleFor(x => x.Email).NotEmpty().NotNull().WithMessage(FluentMessage.Required("Email"));
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
