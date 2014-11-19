using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Datatalbe.Startup))]
namespace Datatalbe
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
