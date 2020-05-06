using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace SwaggerRMQEx.Data
{
    public class ActorService : GeneralService<Actor>
    {
        public ActorService() : base("Actor")
        { }

        public async Task<ActorEntity> GetActorsWithLastName(string lastName)
        {
            return await _db.ActorList.FirstOrDefaultAsync(x => x.LastName == lastName);
        }
    }
}
