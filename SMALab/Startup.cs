using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SMALab.Startup))]
namespace SMALab
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
