using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ecommerceApp.Startup))]
namespace ecommerceApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
