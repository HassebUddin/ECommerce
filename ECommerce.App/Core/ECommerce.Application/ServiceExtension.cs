

//using Microsoft.Extensions.DependencyInjection;


using ECommerce.Application.Abstraction.Service.Storage.Azure;
using ECommerce.Application.Abstraction.Service.Storage.Local;
using ECommerce.Application.Abstraction.Service.Storage;
using ECommerce.Application.FluentValidator.Account;
using ECommerce.Application.FluentValidator.Identity.Role;
using ECommerce.Application.FluentValidator.Identity.User;
using ECommerce.Application.IRepositories;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
namespace ECommerce.Application
{
    public static class ServiceExtension
    {
        public static void AddApplication(this IServiceCollection service)
        {
            //inject automapper
            service.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            //inject fluentvalidation
            service.AddFluentValidationAutoValidation(x => x.DisableDataAnnotationsValidation = true);
            service.AddValidatorsFromAssemblyContaining<RoleCreateValidator>();
            service.AddValidatorsFromAssemblyContaining<RoleUpdateValidator>();

            service.AddValidatorsFromAssemblyContaining<UserCreateValidator>();
            service.AddValidatorsFromAssemblyContaining<UserUpdateValidator>();

            service.AddValidatorsFromAssemblyContaining<LoginValidator>();
            service.AddValidatorsFromAssemblyContaining<ForgetPasswordValidator>();
            service.AddValidatorsFromAssemblyContaining<ResetPasswordValidator>();
            service.AddValidatorsFromAssemblyContaining<ForgetPasswordValidator>();
            service.AddValidatorsFromAssemblyContaining<ConfirmEmailValidator>(); 
            service.AddValidatorsFromAssemblyContaining<VerifyTwoFactorTokenValidator>();



        }




    }
}
