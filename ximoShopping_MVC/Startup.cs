using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ximoShopping_MVC.Startup))]
namespace ximoShopping_MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
