using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApplication1.Account.Models;

namespace WebApplication1.Account.Models
{
    public class SegmentDatabaseInitializer : DropCreateDatabaseIfModelChanges<SegmentContext>
    {
        protected override void Seed(SegmentContext context)
        {
            GetDestinations().ForEach(c => context.Destinations.Add(c));
            GetSegments().ForEach(p => context.Segments.Add(p));
        }

        private static List<Destination> GetDestinations()
        {
            var l = new List<Destination>
            {
                new Destination()
                {
                    DestinationId = 1,
                    DestinationName = "Sierra Leone"
                },
                new Destination()
                {
                    DestinationId = 2,
                    DestinationName = "Tunis"
                },
            };

            return l;
        }

        private static List<Segment> GetSegments()
        {
            var products = new List<Segment>
            {
                new Segment
                {
                    SegmentId = 1,
                    ToId = 1,
                    FromId = 2,
                    Duration = 2.5F,
                },

            };
            return products;
        }
    }
}