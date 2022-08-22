using Newtonsoft.Json.Serialization;
using System.Web.Http;

namespace FacilAssist.API
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member 'WebApiConfig'
    public static class WebApiConfig
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member 'WebApiConfig'
    {
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member 'WebApiConfig.Register(HttpConfiguration)'
        public static void Register(HttpConfiguration config)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member 'WebApiConfig.Register(HttpConfiguration)'
        {
            // Web API configuration and services
            config.EnableCors();
            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Formatters.JsonFormatter.SerializerSettings.ContractResolver =
                new CamelCasePropertyNamesContractResolver();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
