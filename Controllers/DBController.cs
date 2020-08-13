using Microsoft.AspNetCore.Mvc;
using SwaggerRMQTutorial.Data;
using SwaggerRMQTutorial.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SwaggerRMQTutorial.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DBController : ControllerBase
    {
        private readonly ICityService _cityService;
        private readonly IActorService _actorService;

        public DBController(ICityService cityService, IActorService actorService)
        {
            _cityService = cityService;
            _actorService = actorService;
        }

        [HttpGet(nameof(GetRussianCities))]
        public async Task<List<CityEntity>> GetRussianCities()
        {
            return await _cityService.GetRussianCities();
        }

        [HttpGet(nameof(GetActorWithLastName))]
        public async Task<ActorEntity> GetActorWithLastName(string lastName)
        {
            return await _actorService.GetActorsWithLastName(lastName);
        }
    }
}
