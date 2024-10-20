

using AutoMapper;
using ECommerce.Application.Abstraction.Service;
using ECommerce.Application.Messages;
using ECommerce.Domain.Entity.Identity;
using ECommerce.Domain.ViewModel.Request.Identity.Role;
using ECommerce.Domain.ViewModel.Response.Identity.Role;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.Infrastructure.Service
{
    public class RoleService : IRoleService
    {

        private readonly RoleManager<AppRole> _roleManager;

        private readonly IMapper _mapper;
      
        
        public RoleService(RoleManager<AppRole> roleManager, IMapper mapper)
        {
            _roleManager = roleManager;
            _mapper = mapper;
        }

      
        public async Task<object> CreateRoleAsync(RoleCreateRequest roleModel)
        {

            // Check if the role already exists
            bool roleExists = await _roleManager.RoleExistsAsync(roleModel?.Name);
            if (roleExists)
                throw new Exception(EntityMessage.AlreadyExist("Role"));


            var appRole = _mapper.Map<AppRole>(roleModel);
            IdentityResult result = await _roleManager.CreateAsync(appRole);
            if (!result.Succeeded)
                throw new Exception(result.Errors.Select(x => x.Description).FirstOrDefault());

            return EntityMessage.Inserted("Role");

        }
        public async Task<object> UpdateRoleAsync(RoleUpdateRequest roleModel)
        {
            AppRole role = await _roleManager.FindByIdAsync(roleModel.Id);
            if (role == null)
                throw new Exception(EntityMessage.NotFound("Role"));

            var result = await _roleManager.UpdateAsync(_mapper.Map(roleModel, role));
            if (!result.Succeeded)
                throw new Exception(result.Errors.Select(x => x.Description).FirstOrDefault());

            return EntityMessage.Updated("Role");
        }
        public async Task<object> DeleteRoleAsync(string id)
        {
            AppRole role = await _roleManager.FindByIdAsync(id);
            if (role == null)
                throw new Exception(EntityMessage.NotFound("Role"));

            var result = await _roleManager.DeleteAsync(role);
            if (!result.Succeeded)
                throw new Exception(result.Errors.Select(x => x.Description).FirstOrDefault());

            return EntityMessage.Deleted("Role");

        }

        
        
        public async Task<List<RoleResponse>> GetRoleAsync()  => _mapper.Map<List<RoleResponse>>(await _roleManager.Roles.ToListAsync());
        public async Task<RoleResponse> GetRoleByIdAsync(string id)
        {
            AppRole role = await _roleManager.FindByIdAsync(id);
            if (role == null)
                throw new Exception(EntityMessage.NotFound("Role"));

            return _mapper.Map<RoleResponse>(role);

        }
        public async Task<RoleResponse> GetRoleByNameAsync(string name)
        {
            AppRole role = await _roleManager.FindByIdAsync(name);
            if (role == null)
                throw new Exception(EntityMessage.NotFound("Role"));

            return _mapper.Map<RoleResponse>(role);

        }

    }
}

