using Microsoft.Owin;
using Microsoft.Owin.Cors;
using Newtonsoft.Json.Serialization;
using Owin;
using Swashbuckle.Application;
using System;
using System.Web.Http;

[assembly: OwinStartup(typeof(FacilAssist.API.Startup))]


namespace FacilAssist.API
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member 'Startup'
    public class Startup
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member 'Startup'
    {
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member 'Startup.Configuration(IAppBuilder)'
        public void Configuration(IAppBuilder app)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member 'Startup.Configuration(IAppBuilder)'
        {
            var config = new HttpConfiguration();
            config.MapHttpAttributeRoutes();

            config.Formatters.JsonFormatter.SerializerSettings.ContractResolver =
                   new CamelCasePropertyNamesContractResolver();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            config.EnableSwagger(c =>
            {
                c.SingleApiVersion("v1", "FacilAssist.API");
                c.IncludeXmlComments(AppDomain.CurrentDomain.BaseDirectory + @"\bin\FacilAssist.API.xml");
            });

            app.UseCors(CorsOptions.AllowAll);
            app.UseWebApi(config);

        }

    }
}
