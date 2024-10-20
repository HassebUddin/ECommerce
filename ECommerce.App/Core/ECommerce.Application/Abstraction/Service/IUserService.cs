

using ECommerce.Domain.ViewModel.Request.Identity.User;
using ECommerce.Domain.ViewModel.Response.Identity.User;

namespace ECommerce.Application.Abstraction.Service
{
    public interface IUserService
    {
        Task<object> CreateAsync(UserCreateRequest rquest);
        Task<object> UpdateUserAsync(UserUpdateRequest request);
        Task<object> DeleteUserAsync(string id);

        Task<List<UserResponse>> GetUserAsync();
        Task<UserResponse> GetUserByIdAsync(string id);
        Task<UserResponse> GetUserByEmailAsync(string email);
    }
}