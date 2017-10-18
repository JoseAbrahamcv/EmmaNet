using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Emmaweb.Startup))]
namespace Emmaweb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
