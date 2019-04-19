using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ikeepfit_user_.web.Startup))]
namespace ikeepfit_user_.web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
