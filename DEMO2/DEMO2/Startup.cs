using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DEMO2.Startup))]
namespace DEMO2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
