using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Routing.Constraints;
using System.Web.Routing;

namespace ClassWork8
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Route1",
                url: "ath/calculator/sum_{x}_{y}",
                defaults: new
                {
                    controller = "Route",
                    action = "Sum",
                    x = UrlParameter.Optional,
                    y = UrlParameter.Optional
                },
                constraints: new { x = new RangeRouteConstraint(1, 15), y = new RangeRouteConstraint(1, 15)}
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
