using GitImprov.Helpers;
using GitImprov.Models;
using GitImprov.Tests.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitImprov.DataBase
{
    public class GitImprovContext: DbContext
    {
        public DbSet<Test>? Tests { get; set; }
        public DbSet<GuitarPlayer>? GuitarPlayers { get; set; }
        public DbSet<Backingtrack>? Backingtracks { get; set; }
        public DbSet<Mode>? Modes { get; set; }
        public DbSet<Technique>? Techniques { get; set; }

        public string DbPath { get; }

        public GitImprovContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "GitImprov.db");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");
    }
}
