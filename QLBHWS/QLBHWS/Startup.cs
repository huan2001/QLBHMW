using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(QLBHWS.Startup))]
namespace QLBHWS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
