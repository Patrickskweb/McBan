using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(McBan.Startup))]
namespace McBan
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
