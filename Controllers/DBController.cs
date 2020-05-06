using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RabbitMQ.Client;
using SwaggerRMQEx.Data;

namespace SwaggerRMQEx.Controllers
{
    [Route("api/RussianCities")]
    [ApiController]
    public class DBController : ControllerBase
    {
        CityService _cityService = new CityService();

        [HttpGet]
        public async Task<List<CityEntity>> GetRussianCities()
        {
            return await _cityService.GetRussianCities();
        }
    }
}
