using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CareerBuilderWeb.Startup))]
namespace CareerBuilderWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
