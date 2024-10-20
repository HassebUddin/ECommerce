using ECommerce.Domain.ViewModel.Request.Web;

namespace ECommerce.Application.Abstraction.Service.Configuration
{
    public interface IApplicationService
    {

        public List<MenuRequest> GetAuthorizationAttribute(Type type);


    }
}
