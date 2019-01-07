using Blockly.Core.Domain;
using Microsoft.EntityFrameworkCore;

namespace Blockly.Core.Infrastructure
{
    public class BlocklyDbContext : DbContext, IBlocklyDbContext
    {
        private string connectionString;
        public DbSet<Game> Game { get; set; }
        public DbSet<GameMap> GameMap { get; set; }
        public BlocklyDbContext()
        {
            connectionString = GlobalConfig.ConnectionString;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Game>()
                .HasIndex(p => p.Name).IsUnique();
        }
    }
}
