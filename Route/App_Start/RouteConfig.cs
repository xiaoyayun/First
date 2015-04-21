using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Route
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
            null,
            "{category}", // Matches /Football or /AnythingWithNoSlash
            new { controller = "Home", action = "Index", page = 1 }
        );


            routes.MapRoute("MyRoute", "{controller}/{action}");

            routes.MapRoute("MyRoute1", "{controller}/{action}", new { controller = "Home", action = "Index" });
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}