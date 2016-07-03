using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FlashSales.Startup))]
namespace FlashSales
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
