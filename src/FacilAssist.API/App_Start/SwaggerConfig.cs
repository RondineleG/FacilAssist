using FacilAssist.API;
using Swashbuckle.Application;
using System.Web.Http;
using WebActivatorEx;

[assembly: PreApplicationStartMethod(typeof(SwaggerConfig), "Register")]

namespace FacilAssist.API
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member 'SwaggerConfig'
    public class SwaggerConfig
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member 'SwaggerConfig'
    {
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member 'SwaggerConfig.Register()'
        public static void Register()
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member 'SwaggerConfig.Register()'
        {
            var thisAssembly = typeof(SwaggerConfig).Assembly;

            GlobalConfiguration.Configuration
                .EnableSwagger(c =>
                    {
                        c.SingleApiVersion("v1", "FacilAssist.API");
                    })
                .EnableSwaggerUi(c =>
                    {

                    });
        }

    }
}
