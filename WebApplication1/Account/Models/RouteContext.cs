using System.Data.Entity;
using WebApplication1.Account.Models;

namespace WebApplication1.Account.Models
{
    public class RouteContext : DbContext
    {
        public RouteContext() : base("WebApplication1")
        {
        }
        public DbSet<Route> Routes { get; set; }
        public DbSet<Destination> Destinations { get; set; }
        public DbSet<Fee> Fees { get; set; }

    }
}