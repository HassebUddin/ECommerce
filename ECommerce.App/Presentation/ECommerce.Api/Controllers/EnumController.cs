using ECommerce.Domain.Entity.Identity;
using ECommerce.Domain.ViewModel.Response.Web.Enums;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnumController : ControllerBase
    {

        [HttpGet("professions")]
        public IActionResult GetProfessions()
        {
            var professions = Enum.GetValues(typeof(Profession))
                .Cast<Profession>()
                .Select(p => new ProfessionResponse
                {
                    Name = p.ToString(), // Profession name (string)
                    Value = ((int)p).ToString() // Profession value (int)
                })
                .ToList();

            return Ok(professions);
        }


        [HttpGet("cities")]
        public IActionResult GetCities()
        {
            var cities = Enum.GetValues(typeof(City))
                .Cast<City>()
                .Select(p => new CityResponse
                {
                    Name = p.ToString(), // City name (string)
                    Value = ((int)p).ToString() // City value (int)
                })
                .ToList();

            return Ok(cities);
        }



        [HttpGet("countries")]
        public IActionResult GetCountries()
        {
            var countries = Enum.GetValues(typeof(Country))
                .Cast<Country>()
                .Select(p => new CountryResponse
                {
                    Name = p.ToString(), // Country name (string)
                    Value = ((int)p).ToString() // Country value (int)
                })
                .ToList();

            return Ok(countries);
        }
    }
}
