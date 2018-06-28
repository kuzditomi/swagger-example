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
            var config = new HttpConfiguration();
            config.MapHttpAttributeRoutes();

            // use json formatter only
            config.Formatters.Remove(config.Formatters.XmlFormatter);

            app.UseWebApi(config);
        }
    }
}
