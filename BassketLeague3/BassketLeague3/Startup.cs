using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BassketLeague3.Startup))]
namespace BassketLeague3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
