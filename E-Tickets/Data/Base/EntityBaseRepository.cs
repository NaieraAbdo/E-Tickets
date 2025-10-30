
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
        public Task AddAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            var Result = await context.Set<T>().ToListAsync();
            return Result;
        
        }

        public async Task<T> GetByIdAsync(int id)
        => await context.Set<T>().FirstOrDefaultAsync(n => n.Id == id);
        

        public Task<T> UpdateAsync(T newEntity, int id)
        {
            throw new NotImplementedException();
        }
    }
}
