using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Zinix.Startup))]

namespace Zinix
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}