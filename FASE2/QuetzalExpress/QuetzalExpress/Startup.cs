using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(QuetzalExpress.Startup))]
namespace QuetzalExpress
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
