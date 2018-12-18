using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Comix.Startup))]
namespace Comix
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
