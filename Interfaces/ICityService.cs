using SwaggerRMQTutorial.Data;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SwaggerRMQTutorial.Interfaces
{
    public interface ICityService
    {
        Task<List<CityEntity>> GetRussianCities();
    }
}
