using ECommerce.Application.Abstraction.Service;
using ECommerce.Domain.ViewModel.Request.Identity.User;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ECommerce.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }



        // GET: api/<UserController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _userService.GetUserAsync());
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            return Ok(await _userService.GetUserByIdAsync(id));
        }

        // POST api/<UserController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] UserCreateRequest request)
        {
            return Ok(await _userService.CreateAsync(request));
        }

        // PUT api/<UserController>/5
        [HttpPut]
        public async Task<IActionResult> Put(UserUpdateRequest request)
        {
            return Ok(await _userService.UpdateUserAsync(request));
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            return Ok(await _userService.DeleteUserAsync(id));
        }
    }
}
