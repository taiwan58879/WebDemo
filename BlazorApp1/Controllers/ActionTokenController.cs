using BlazorApp1.Data;
using Microsoft.AspNetCore.Mvc;

namespace BlazorApp1.Controllers
{
    [Route("api/Users")]
    [ApiController]
    public class ActionTokenController : ControllerBase
    {

        public ActionTokenController()
        {

        }

        [HttpPost("[action]")]
        public WeatherForecast Authenticate()
        {
            return new WeatherForecast()
            {
                Date = DateTime.Now,
                Summary = "Hello World",
                TemperatureC = 32,
            };
        }
    }
}