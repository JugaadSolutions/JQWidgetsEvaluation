using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcDemoSample.Startup))]
namespace MvcDemoSample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
