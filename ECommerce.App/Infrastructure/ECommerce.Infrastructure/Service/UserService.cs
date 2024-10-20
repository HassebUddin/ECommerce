

using AutoMapper;
using ECommerce.Application.Abstraction.Service;
using ECommerce.Application.Messages;
using ECommerce.Domain.Entity.Identity;
using ECommerce.Domain.ViewModel.Request.Identity.User;
using ECommerce.Domain.ViewModel.Response.Identity.User;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.Infrastructure.Service
{
    public class UserService:IUserService
    {
        private readonly UserManager<AppUser> _userManager;

        private readonly IMapper _mapper;

        public UserService(UserManager<AppUser> userManager, IMapper mapper)
        {
            _userManager = userManager;
            _mapper = mapper;
        }

        public async Task<object> CreateAsync(UserCreateRequest rquest)
        {
            var isUserExist =await _userManager.FindByEmailAsync(rquest.Email);
            if(isUserExist != null)
                throw new Exception(EntityMessage.AlreadyExist("User"));

            var appUser=_mapper.Map<AppUser>(rquest);
            var result=await _userManager.CreateAsync(appUser, rquest.Password);
                if (!result.Succeeded)
                    throw new Exception(result.Errors.Select(x => x.Description).FirstOrDefault());

            return EntityMessage.Inserted("User");

        }
        public async Task<object> UpdateUserAsync(UserUpdateRequest request)
        {
            AppUser user = await _userManager.FindByIdAsync(request.Id);
            if (user == null)
                throw new Exception(EntityMessage.NotFound("User"));

            var result = await _userManager.UpdateAsync(_mapper.Map(request, user));
            if (!result.Succeeded)
                throw new Exception(result.Errors.Select(x => x.Description).FirstOrDefault());

            return EntityMessage.Updated("User");
        }
        public async Task<object> DeleteUserAsync(string id)
        {
            AppUser user= await _userManager.FindByIdAsync(id);
            if (user == null)
                throw new Exception(EntityMessage.NotFound("User"));

            var result = await _userManager.DeleteAsync(user);
            if (!result.Succeeded)
                throw new Exception(result.Errors.Select(x => x.Description).FirstOrDefault());

            return EntityMessage.Deleted("User");

        }


        public async Task<List<UserResponse>> GetUserAsync()=> _mapper.Map<List<UserResponse>>(await _userManager.Users.ToListAsync());
        public async Task<UserResponse> GetUserByIdAsync(string id)
        {
            AppUser user = await _userManager.FindByIdAsync(id);
            if (user == null)
                throw new Exception(EntityMessage.NotFound("User"));

            return _mapper.Map<UserResponse>(user);

        }
        public async Task<UserResponse> GetUserByEmailAsync(string email)
        {

            AppUser user = await _userManager.FindByEmailAsync(email);
            if (user == null)
                throw new Exception(EntityMessage.NotFound("User"));

            return _mapper.Map<UserResponse>(user);

        }

       
    }
}
