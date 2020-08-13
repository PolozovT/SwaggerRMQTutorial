using Microsoft.EntityFrameworkCore;
using SwaggerRMQTutorial.Interfaces;
using System.Threading.Tasks;

namespace SwaggerRMQTutorial.Data
{
    public class ActorService : GeneralService<Actor>, IActorService
    {
        public ActorService() : base("Actor")
        { }

        public async Task<ActorEntity> GetActorsWithLastName(string lastName)
        {
            return await _db.ActorList.FirstOrDefaultAsync(x => x.LastName == lastName);
        }
    }
}
