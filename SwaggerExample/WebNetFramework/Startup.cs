using Microsoft.Owin;
using Owin;
using System.Web.Http;

[assembly: OwinStartup(typeof(WebNetFramework.Startup))]

namespace WebNetFramework
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // create httpconfig with json formatter only
            var config = new HttpConfiguration();
            config.MapHttpAttributeRoutes();
            config.Formatters.Remove(config.Formatters.XmlFormatter);

            // add swagger
            SwaggerConfig.Register(config);

            // include webapi
            app.UseWebApi(config);
        }
    }
}
