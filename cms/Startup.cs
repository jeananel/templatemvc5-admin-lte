using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(cms.Startup))]
namespace cms
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
