using ECommerce.Application.Abstraction.Service.Configuration;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ECommerce.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ApplicationServiceController : ControllerBase
    {
        private readonly IApplicationService  _applicationService;

        public ApplicationServiceController(IApplicationService applicationService)
        {
            _applicationService = applicationService;
        }

        [HttpGet]
        public IActionResult GetAuthorizationDefinitionEndPoints()
        {
            return Ok(_applicationService.GetAuthorizationAttribute(typeof(Program)));
        }
    }
}
