using BlazorApp1.Data;
using Microsoft.AspNetCore.Mvc;

namespace BlazorApp1.Controllers
{
    [Route("api/Users")]
    [ApiController]
    public class ActionTokenController : ControllerBase
    {
        [HttpPost("[action]")]
        public WeatherForecast Authenticate(AuthenticateParam authenticateParam)
        {
            return new WeatherForecast()
            {
                Date = DateTime.Now,
                Summary = authenticateParam.Name,
                TemperatureC = 32,
            };
        }
    }
}