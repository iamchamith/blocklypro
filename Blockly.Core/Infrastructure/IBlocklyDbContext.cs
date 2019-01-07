using Blockly.Core.Domain;
using Microsoft.EntityFrameworkCore;

namespace Blockly.Core.Infrastructure
{
    public interface IBlocklyDbContext
    {
        DbSet<Game> Game { get; set; }
        DbSet<GameMap> GameMap { get; set; }
    }
}
