using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApplication1.Account.Models;

namespace WebApplication1.Account.Models
{
    public class RouteDatabaseInitializer : DropCreateDatabaseIfModelChanges<RouteContext>
    {
        protected override void Seed(RouteContext context)
        {
            GetDestinations().ForEach(c => context.Destinations.Add(c));
            GetRoutes().ForEach(p => context.Routes.Add(p));
        }

        private static List<Destination> GetDestinations()
        {
            var l = new List<Destination>
            {
                new Destination()
                {
                    DestinationID = 1,
                    DestinationName = "Sierra Leone"
                },
                new Destination()
                {
                    DestinationID = 2,
                    DestinationName = "Tunis"
                },
            };

            return l;
        }

        private static List<Route> GetRoutes()
        {
            var products = new List<Route>
            {
                new Route
                {
                    RouteID = 1,
                    ToID = 1,
                    FromId = 2,
                    fragttid = 2.5,
                },

            };
            return products;
        }
    }
}