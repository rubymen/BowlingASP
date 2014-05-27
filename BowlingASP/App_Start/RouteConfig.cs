using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace BowlingASP
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Game", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name:"Filter",                                              
                url: "{controller}/{action}/{state}",
                defaults: new { controller = "Game", action = "Filter", state = UrlParameter.Optional } 
            );
            routes.MapRoute(
                name: "Delete",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Player", action = "Delete", id = UrlParameter.Optional }
            );
        }
    }
}