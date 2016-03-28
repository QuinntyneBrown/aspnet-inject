using System.Web.Mvc;
using System.Web.Routing;

namespace Chloe.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            
            routes.MapRoute(
                name: "Default",
                url: "{*catch-all}",
                defaults: new { controller = "Default", action ="Index" }
            );           
        }
    }
}