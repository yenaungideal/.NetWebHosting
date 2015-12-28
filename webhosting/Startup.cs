using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(webhosting.Startup))]
namespace webhosting
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
