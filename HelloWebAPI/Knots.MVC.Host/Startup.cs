using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Knots.MVC.Host.Startup))]
namespace Knots.MVC.Host
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
