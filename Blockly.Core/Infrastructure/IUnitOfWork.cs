using System.Threading.Tasks;
using Blockly.Core.Domain;
using Microsoft.EntityFrameworkCore;

namespace Blockly.Core.Infrastructure
{
    public interface IUnitOfWork
    {
        Repository<Game> GameRepository { get;  }
        Repository<GameMap> GameMapRepository { get;}
        void Save();
        Task SaveAsync();
        DbContext Context { get; }
        string ConnectionString { get; }
    }
}
