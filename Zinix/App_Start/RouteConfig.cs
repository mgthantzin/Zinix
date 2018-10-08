using System.Web.Mvc;
using System.Web.Routing;

namespace Zinix
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapMvcAttributeRoutes();

            //routes.MapRoute(
            //    "MoviesByReleaseDate",
            //    "movies/released/{year}/{month}",
            //    new { controller = "Movies", action = "ByReleaseDate"},
            //    new { year = @"2015|2016", month = @"\d{2}"}
            //);

            //routes.MapRoute(
            //    name: "EditMovie",
            //    url: "movies/edit/{movieId}",
            //    defaults: new { controller = "Movies", action = "Edit", movieId = 0 }
            //);

            //routes.MapRoute(
            //    name: "BrowseMovie",
            //    url: "movies/{pageIndex}/{sortBy}",
            //    defaults: new { controller = "Movies", action = "Index", pageIndex = UrlParameter.Optional, sortBy = UrlParameter.Optional }
            //);

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}