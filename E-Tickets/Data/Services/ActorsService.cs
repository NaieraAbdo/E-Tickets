using E_Tickets.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace E_Tickets.Data.Services
{
    public class ActorsService : IActorsService
    {
        private readonly AppDbContext context;

        public ActorsService(AppDbContext context)
        {
            this.context = context;
        }
        public async Task AddAsync(Actor actor)
         {
           await context.Actors.AddAsync(actor);
           await context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
           var res = await context.Actors.FirstOrDefaultAsync(n => n.Id == id);
            context.Actors.Remove(res);
            await context.SaveChangesAsync();

        }

        public async Task<IEnumerable<Actor>> GetAllAsync()
        {
            var Result = await context.Actors.ToListAsync();
            return Result;
        }

        public async Task<Actor> GetByIdAsync(int id)
        {
            return await context.Actors.FirstOrDefaultAsync(n => n.Id == id);
        }

        public async Task<Actor> UpdateAsync(Actor newActor, int id)
        {
            context.Update(newActor);
            await context.SaveChangesAsync();
            return newActor;
        }
    }
}
