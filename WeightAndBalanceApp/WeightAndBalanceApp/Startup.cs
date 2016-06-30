using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WeightAndBalanceApp.Startup))]
namespace WeightAndBalanceApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
