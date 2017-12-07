using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.Account.Models;

namespace WebApplication1
{
    public partial class Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IQueryable<Destination> GetDestinations()
        {
            var db = new WebApplication1.Account.Models.SegmentContext();
            IQueryable<Destination> query = db.Destinations;
            return query;
        }

    }
}