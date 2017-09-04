using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FrontEndEndDinges.Startup))]
namespace FrontEndEndDinges
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
