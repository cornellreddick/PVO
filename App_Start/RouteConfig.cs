using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace PVO
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //Attribute route allows you to create the custom route in the controller. 
            routes.MapMvcAttributeRoutes();

            //custom route single route
//            routes.MapRoute(
//                "MoviesByReleaseDate",
//                "movie/released/{year}/{month}",
//                new {controller = "Movie", action = "ByReleaseDate"},
//                new { year = @"\d{4}", month = @"\d{2}"}
//                );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
