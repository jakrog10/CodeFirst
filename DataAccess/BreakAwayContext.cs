using Model;
using System.Data.Entity;

namespace DataAccess
{
    public class BreakAwayContext: DbContext
    {
        public DbSet<Destination> Destinations { get; set; }
        public DbSet<Lodging> Lodgings { get; set; }
    }
}
