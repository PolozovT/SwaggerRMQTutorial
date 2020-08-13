using SwaggerRMQTutorial.Data;
using System.Threading.Tasks;

namespace SwaggerRMQTutorial.Interfaces
{
    public interface IActorService
    {
        Task<ActorEntity> GetActorsWithLastName(string lastName);
    }
}
