using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitImprov.DataBase
{
    internal class DataBaseConnection: DbContext
    {
        public DataBaseConnection() : base("DataBaseConnectionPath")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //modelBuilder.Entity<Klasa>().ToTable("Klasa");
        }

        //public virtual DbSet<Klasa> Klase { get; set; };
    }
}
