using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(gridview.Startup))]
namespace gridview
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
