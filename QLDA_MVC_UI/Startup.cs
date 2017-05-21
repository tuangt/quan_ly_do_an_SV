using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(QLDA_MVC_UI.Startup))]
namespace QLDA_MVC_UI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
