using ECommerce.Application.Abstraction.Service;

using ECommerce.Domain.ViewModel.Request.Account;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ECommerce.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly ITokenService _tokenService;
        private readonly IAccountService  _accountService;

        public AccountController(ITokenService tokenService, IAccountService accountService)
        {
            _tokenService = tokenService;
            _accountService = accountService;
        }


        [HttpPost("[action]")]
        public async Task<IActionResult> Register([FromBody] RegisterRequest request)
        {
            try
            {
                var res = await _accountService.RegisterAsync(request);
                return Ok(res);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }


        }


        [HttpPost("[action]")]
        public async Task<IActionResult> Login([FromBody] LoginRequest request)
        {
            try
            {
                var res = await _accountService.LoginAsync(request);
                return Ok(res);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }


        }

        [HttpPost("[action]")]
        public async Task<IActionResult> ForgetPassword([FromBody]ForgetPasswordRequest request)
        {
            try
            {
                var res = await _accountService.ForgotPasswordAsync(request);
                return Ok(res);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }


        }


        [HttpPost("[action]")]
        public async Task<IActionResult> ResetPassword([FromBody]ResetPasswordRequest request)
        {
            try
            {

                var res = await _accountService.ResetPasswordAsync(request);
                return Ok(res);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }


        }


        [HttpPost("Login-2F")]
        public async Task<IActionResult> VerifyTwoFactorToken([FromQuery] VerifyTwoFactorTokenRequest request)
        {
            try
            {
                var res = await _accountService.VerifyTwoFactorTokenAsync(request);
                return Ok(res);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }


        }


        [HttpPost("[action]")]
        public async Task<IActionResult> ConfirmEmail([FromBody] ConfirmEmailRequest request)
        {
            try
            {
                var res = await _accountService.ConfirmEmail(request);
                return Ok(res);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }


        }

        [HttpPost("[action]")]
        public async Task<IActionResult> RefreshToken([FromBody] JwtTokenRequest tokenRequest)
        {
            try
            {
                var res = await _tokenService.VerifyTokenAsync(tokenRequest);
                return Ok(res);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }


        }


    }
}
