using GitImprov.Models;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace GitImprov.Data.Context
{
    public class GitImprovContext : DbContext
    {
        private readonly string _dbPath;

        public DbSet<GuitarPlayer>? GuitarPlayers { get; set; }
        public DbSet<BackingTrack>? BackingTracks { get; set; }
        public DbSet<Mode>? Modes { get; set; }
        public DbSet<Technique>? Techniques { get; set; }



        public GitImprovContext()
        {
            _dbPath = ConfigurationManager.ConnectionStrings["DatabaseLocationPath"].ConnectionString;  
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlite(_dbPath);
    }
}
