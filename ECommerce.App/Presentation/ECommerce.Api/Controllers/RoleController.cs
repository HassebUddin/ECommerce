using ECommerce.Application.Abstraction.Service;
using ECommerce.Domain.ViewModel.Request.Identity.Role;
using ECommerce.Domain.ViewModel.Request.Identity.User;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class RoleController : ControllerBase
    {

        private readonly IRoleService _roleService;

        public RoleController(IRoleService roleService)
        {
            _roleService = roleService;
        }



        // GET: api/<UserController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _roleService.GetRoleAsync());
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            return Ok(await _roleService.GetRoleByIdAsync(id));
        }

        // POST api/<UserController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] RoleCreateRequest request)
        {
            return Ok(await _roleService.CreateRoleAsync(request));
        }

        // PUT api/<UserController>/5
        [HttpPut]
        public async Task<IActionResult> Put([FromBody] RoleUpdateRequest request)
        {
            return Ok(await _roleService.UpdateRoleAsync(request));
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            return Ok(await _roleService.DeleteRoleAsync(id));
        }
    }
}
