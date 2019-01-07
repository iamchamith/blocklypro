using System;
using System.Linq;
using System.Threading.Tasks;
using Blockly.Core.Domain;
using Microsoft.EntityFrameworkCore;

namespace Blockly.Core.Infrastructure
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        public IQueryable<T> TableAsNoTracking => context.Set<T>().AsNoTracking();
        public IQueryable<T> Table => context.Set<T>();
        private readonly DbContext context;
        private readonly DbSet<T> dbSet;

        public Repository(DbContext context)
        {
            this.context = context;
            dbSet = context.Set<T>();
        }
        public async Task<T> Create(T entity)
        {
            await dbSet.AddAsync((T)entity);
            return entity;
        }

        public async Task Delete(int id)
        {
            var entity = await Table.FirstOrDefaultAsync(p => p.Id == id);
            context.Entry(entity).State = EntityState.Modified;
        }
 
        public Task Update(T entity)
        {
           throw new UnauthorizedAccessException();
        }

        public Task<T> Read(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
