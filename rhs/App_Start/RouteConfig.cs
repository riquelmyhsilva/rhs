using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace rhs
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "Home/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "AboutMe",
                url: "Home/AboutMe",
                defaults: new { controller = "Home", action = "AboutMe" }
            );

            routes.MapRoute(
                name: "Contact",
                url: "Home/Contact",
                defaults: new { controller = "Home", action = "Contact" }
            );

            routes.MapRoute(
                name: "DolbyCinema",
                url: "Home/DolbyCinema",
                defaults: new { controller = "Home", action = "DolbyCinema" }
            );

            routes.MapRoute(
                name: "Calculator",
                url: "Home/Calculator",
                defaults: new { controller = "Home", action = "Calculator" }
            );

            routes.MapRoute(
                name: "Bdc",
                url: "Home/Bdc",
                defaults: new { controller = "Home", action = "Bdc" }
            );

            routes.MapRoute(
                name: "PhraseRewriter",
                url: "Home/PhraseRewriter",
                defaults: new { controller = "Home", action = "PhraseRewriter" }
            );

            routes.MapRoute(
                name: "RegistrarEmail",
                url: "HomeController/RegistrarEmail",
                defaults: new { controller = "HomeController", action = "RegistrarEmail" }
            );

        }
    }
}
