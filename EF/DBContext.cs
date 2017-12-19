using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ThingGrabber.EF
{
    public class DBContext<T> : DbContext where T : class
    {
        public DbSet<T> DBSet { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Data Source={typeof(T).FullName}.db");
        }
    }

}