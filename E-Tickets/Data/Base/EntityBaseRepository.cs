
using E_Tickets.Models;
using Microsoft.EntityFrameworkCore;

namespace E_Tickets.Data.Base
{
    public class EntityBaseRepository<T> : IEntityBaseRepository<T> where T : class, IEntityBase, new()
    {
        private readonly AppDbContext context;

        public EntityBaseRepository(AppDbContext context)
        {
            this.context = context;
        }
        public async Task AddAsync(T entity)
        {
            await context.Set<T>().AddAsync(entity);
            await context.SaveChangesAsync();
        }        

        public async Task DeleteAsync(int id)
        {
            var res = await context.Set<T>().FirstOrDefaultAsync(n => n.Id == id);
            //context.Set<T>().Remove(res);
            //await context.SaveChangesAsync();
            var EntityEntry = context.Entry<T>(res);
            EntityEntry.State = EntityState.Deleted;
            await context.SaveChangesAsync();
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            var Result = await context.Set<T>().ToListAsync();
            return Result;
        
        }

        public async Task<T> GetByIdAsync(int id)
        => await context.Set<T>().FirstOrDefaultAsync(n => n.Id == id);
        

        public async Task UpdateAsync(T newEntity, int id)
        {
            var EntityEntry = context.Entry<T>(newEntity);
            EntityEntry.State = EntityState.Modified;
            await context.SaveChangesAsync();
        }
    }
}
