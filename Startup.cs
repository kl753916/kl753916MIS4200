using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(kl753916MIS4200.Startup))]
namespace kl753916MIS4200
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
