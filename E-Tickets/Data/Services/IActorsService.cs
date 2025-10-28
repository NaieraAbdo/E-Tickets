using E_Tickets.Models;

namespace E_Tickets.Data.Services
{
    public interface IActorsService
    {
        Task<IEnumerable<Actor>> GetAllAsync();
        Actor GetById (int id);
        void Add(Actor actor);
        Actor Update(Actor newActor, int id);
        void Delete(int id);
    }
}
