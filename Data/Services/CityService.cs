using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SwaggerRMQEx.Data
{
    public class CityService : GeneralService<City>
    {
        public CityService() : base("City")
        { }

        public async Task<List<CityEntity>> GetRussianCities()
        {
            Console.WriteLine("[CityService] <GetRussianCities>");
            var rusCities = await _db.CityList.Where(x => x.CityId == 80).ToListAsync();
            return rusCities.ToList();
        }

        public void ss()
        {
            var a = _db.CityList.Where(x => x.CityId == 1);
        }
    }
}
