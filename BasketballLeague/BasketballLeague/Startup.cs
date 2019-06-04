using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BasketballLeague.Startup))]
namespace BasketballLeague
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
