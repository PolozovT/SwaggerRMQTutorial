using Microsoft.AspNetCore.Mvc;
using SwaggerRMQTutorial.Data;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SwaggerRMQTutorial.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DBController : ControllerBase
    {
        private readonly CityService _cityService = new CityService();
        private readonly ActorService _actorService = new ActorService();


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
