using System.Web.Mvc;
using System.Web.Routing;

namespace AnagramWebsite
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Anagram", action = "Search", id = UrlParameter.Optional }
            );
        }
    }
}
