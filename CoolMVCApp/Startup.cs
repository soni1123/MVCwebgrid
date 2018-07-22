using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CoolMVCApp.Startup))]
namespace CoolMVCApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
