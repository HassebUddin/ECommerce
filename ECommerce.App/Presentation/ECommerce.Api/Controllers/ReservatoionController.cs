using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ReservatoionController : ControllerBase
    {



        [HttpPost]
        public async Task<IActionResult> CheckIn()
        {
            return Ok();
        }



    }
}
