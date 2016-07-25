using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AircraftBalance.Startup))]
namespace AircraftBalance
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
