using System.Data.Entity;
using WebApplication1.Account.Models;

namespace WebApplication1.Account.Models
{
    public class SegmentContext : DbContext
    {
        public SegmentContext() : base("WebApplication1")
        {
        }
        public DbSet<Segment> Segments { get; set; }
        public DbSet<Destination> Destinations { get; set; }
        public DbSet<Types> Types { get; set; }

        public DbSet<Carrier> Carriers { get; set; }

    }
}