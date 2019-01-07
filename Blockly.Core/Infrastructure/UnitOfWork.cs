using System.Threading.Tasks;
using Blockly.Core.Domain;
using Microsoft.EntityFrameworkCore;
using System;

namespace Blockly.Core.Infrastructure
{
    public class UnitOfWork: IUnitOfWork
    {
        private bool disposed;
        private Repository<Game> gameRepository;
        private Repository<GameMap> gameMapRepository;
        public Repository<Game> GameRepository => gameRepository ?? (gameRepository = new Repository<Game>(Context));
        public Repository<GameMap> GameMapRepository => gameMapRepository ?? (gameMapRepository = new Repository<GameMap>(Context));
        public DbContext Context { get; set; }
        public string ConnectionString => Context.Database.GetDbConnection().ConnectionString;

        public UnitOfWork(IBlocklyDbContext dbcontext)
        {
            Context = (BlocklyDbContext) dbcontext;
        }

        public void Save()
        {
            Context.SaveChanges();
        }
        public async Task SaveAsync()
        {
            await Context.SaveChangesAsync();
        }
        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    Context.Dispose();
                }
            }
            disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
