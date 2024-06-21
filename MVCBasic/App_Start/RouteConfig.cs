using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVCBasic
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

         //   routes.MapMvcAttributeRoutes();// to enable attribute based routing
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Welcome", id = UrlParameter.Optional }
            );
             /*routes.MapRoute(
                name: "Default1",
                url: "{controller}/{action}/{id}/{name}",
                defaults: new { controller = "Home", action = "Welcome", id = UrlParameter.Optional }
            );*/

        }
    }
}
