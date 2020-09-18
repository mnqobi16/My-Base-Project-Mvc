using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NewPSL.Startup))]
namespace NewPSL
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
