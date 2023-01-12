using eTickets.Models;

namespace eTickets.Data.Services
{
    public interface IActorService
    {
        IEnumerable<Actor> GetAll();
        Actor GetBy(int id);
        void Add(Actor actor);
        Actor Update(int id, Actor newActor);
        void Delete(int id);

    }
}
