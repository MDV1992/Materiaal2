using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Materiaal.Startup))]
namespace Materiaal
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
