using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ikeepfit.web.Startup))]
namespace ikeepfit.web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
