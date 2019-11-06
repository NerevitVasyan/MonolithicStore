namespace MonolithicStore.DataAccess
{
    using MonolithicStore.DataAccess.Entities;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class AppContext : DbContext
    {
        public AppContext()
            : base("name=AppContext")
        {
        }

        public DbSet<Game> Games { get; set; }
        public DbSet<Genre> Genres { get; set; }
    }
}