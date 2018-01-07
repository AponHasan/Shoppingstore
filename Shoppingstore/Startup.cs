using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Shoppingstore.Startup))]
namespace Shoppingstore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
