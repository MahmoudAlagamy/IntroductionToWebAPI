using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace IntroductionToWebAPI
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes => Attribute-based routing
            config.MapHttpAttributeRoutes();

            // Convertion-based routing
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            // Examples
            // http://www.mobarmijoun.com/api/posts/archive/2020/02/23
            // http://www.mobarmijoun.com/api/posts/archive/2020/02 => Optional
            // http://www.mobarmijoun.com/api/posts/archive/2020 => Optional

            config.Routes.MapHttpRoute(
                name: "MyRout",
                routeTemplate: "api/{controller}/{action}/{year}/{month}/{day}",
                defaults: new {
                    month = RouteParameter.Optional,
                    day = RouteParameter.Optional
                },
                constraints: new
                {
                    month = @"\d{0,2}", // => d = digit رقمية
                    day = @"\d{0,2}"
                }
            );

        }
    }
}
