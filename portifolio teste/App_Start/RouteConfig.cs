using System.Web.Mvc;
using System.Web.Routing;

namespace portifolio_teste
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "~/Views/Shared/_LayoutPage1.cshtml", action = "", id = UrlParameter.Optional }
            );
        }
    }
}
