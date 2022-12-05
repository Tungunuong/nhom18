using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Webbhtp_18.Startup))]
namespace Webbhtp_18
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
