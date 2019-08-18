using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace Demo
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

			config.Formatters.JsonFormatter.SupportedMediaTypes
				.Add(new System.Net.Http.Headers.MediaTypeHeaderValue("text/html"));

			config.Routes.MapHttpRoute(
				name: "GetByFirstName",
				routeTemplate: "api/{controller}/firstname/{firstName}",
				defaults: new { firstName = RouteParameter.Optional }
			);

			config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

        }
    }
}
