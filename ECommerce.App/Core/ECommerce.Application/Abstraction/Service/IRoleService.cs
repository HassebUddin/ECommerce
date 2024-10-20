
using ECommerce.Domain.ViewModel.Request.Identity.Role;
using ECommerce.Domain.ViewModel.Response.Identity.Role;

namespace ECommerce.Application.Abstraction.Service
{
    public interface IRoleService
    {
        Task<object> CreateRoleAsync(RoleCreateRequest roleModel);
        Task<object> UpdateRoleAsync(RoleUpdateRequest roleModel);
        Task<object> DeleteRoleAsync(string id);


        Task<List<RoleResponse>> GetRoleAsync();
        Task<RoleResponse> GetRoleByIdAsync(string id);
        Task<RoleResponse> GetRoleByNameAsync(string name);
    }
}
