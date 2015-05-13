using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProjectAurora.Startup))]
namespace ProjectAurora
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
