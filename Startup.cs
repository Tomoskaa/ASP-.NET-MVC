using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Av9.Startup))]
namespace Av9
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
