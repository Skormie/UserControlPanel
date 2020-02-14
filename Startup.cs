using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UserControlPanel.Startup))]
namespace UserControlPanel
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
