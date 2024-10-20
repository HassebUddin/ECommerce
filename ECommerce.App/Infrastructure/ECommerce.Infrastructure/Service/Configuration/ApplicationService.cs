

using ECommerce.Application.Abstraction.Service.Configuration;
using ECommerce.Application.CustomAttribute;
using ECommerce.Application.Enums;
using ECommerce.Domain.ViewModel.Request.Web;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;
using System.Reflection;

namespace ECommerce.Infrastructure.Service.Configuration
{
    public class ApplicationService : IApplicationService
    {
        public List<MenuRequest> GetAuthorizationAttribute(Type type)
        {
             List<MenuRequest> menus = new List<MenuRequest>();
             var assembly = Assembly.GetAssembly(type);
             var controllers=   assembly.GetTypes().Where(x => x.IsAssignableTo(typeof(ControllerBase)));
            if (controllers.Any())
            {
                foreach(var controller in controllers)
                {
                    var actions = controller.GetMethods().Where(x => x.IsDefined(typeof(AuthorizationCustomAttribute)));
                    if (actions.Any())
                    {
                        foreach(var  action in actions)
                        {
                            var attributes = action.GetCustomAttributes(true);
                            if(attributes != null)
                            {
                                MenuRequest menu = null!;
                                var authorizationCustomAttribute=attributes.FirstOrDefault(x=>x.GetType() == typeof(AuthorizationCustomAttribute)) as AuthorizationCustomAttribute;
                                if (!menus.Any(x => x.Name == authorizationCustomAttribute?.Menu))
                                    menus.Add(new MenuRequest { Name = authorizationCustomAttribute?.Menu! });
                                else
                                    menu = menus.FirstOrDefault(x => x.Name == authorizationCustomAttribute?.Menu)!;

                                ActionRequest _action = new ActionRequest
                                {
                                    ActionType = Enum.GetName(typeof(ActionTypeEnum), authorizationCustomAttribute?.ActionType!)!,
                                    Definition = authorizationCustomAttribute?.Definition!
                                };

                                var httpAttribute = attributes.FirstOrDefault(x => x.GetType() == typeof(HttpMethodAttribute)) as HttpMethodAttribute;
                                if (httpAttribute != null)
                                    _action.HttpType = httpAttribute.HttpMethods.First();
                                else
                                    _action.HttpType = HttpMethods.Get;

                                _action.Code = $"{_action.ActionType},{_action.HttpType},{_action.Definition}".Replace(" ","");

                            }
                        }
                    }
                }    
            }
            return   menus;


        }
    }
}
