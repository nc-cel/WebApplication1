using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Routing;
using Microsoft.AspNet.FriendlyUrls;

namespace WebApplication1
{
    public static class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection Routes)
        {
            var settings = new FriendlyUrlSettings();
            settings.AutoRedirectMode = RedirectMode.Permanent;
            Routes.EnableFriendlyUrls(settings);
        }
    }
}
