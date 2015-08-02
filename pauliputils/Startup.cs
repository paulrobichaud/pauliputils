using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(pauliputils.Startup))]
namespace pauliputils
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
