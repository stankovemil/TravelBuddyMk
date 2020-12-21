using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TravelBuddy.mk.Startup))]
namespace TravelBuddy.mk
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
