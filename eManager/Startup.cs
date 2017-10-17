using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(eManager.Startup))]
namespace eManager
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
