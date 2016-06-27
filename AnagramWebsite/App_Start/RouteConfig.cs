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
                url: "{controller}/{action}/{hintPhrase}/{md5HashKey}",
                defaults: new { controller = "Anagram", action = "Search", hintPhrase = UrlParameter.Optional, md5HashKey = UrlParameter.Optional }
            );
        }
    }
}
