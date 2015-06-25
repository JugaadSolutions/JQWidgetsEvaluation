using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JQgridMVC.Startup))]
namespace JQgridMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
